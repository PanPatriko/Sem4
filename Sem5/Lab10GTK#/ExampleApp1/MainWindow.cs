using System;
using System.Collections.Generic;
using Gtk;

namespace ExampleApp1
{

    /// <summary> Example Test Form for GTKSharp and Glade. </summary>
    public class MainWindow : Window
    {
        #region Properties

        /// <summary> Used to load in the glade file resource as a window. </summary>
        private Builder _builder;

#pragma warning disable 649

        /// <summary> Connects to the SendButton on the Glade Window. </summary>
        [Builder.Object]
        private Button GtkButton_Calculate;
        [Builder.Object]
        private Button GtkButton_AddSubject;
        [Builder.Object]

        private Button GtkB1;
        [Builder.Object]
        private Button GtkB2;
        [Builder.Object]
        private Button GtkB3;
        [Builder.Object]
        private Button GtkB4;
        [Builder.Object]
        private Button GtkB5;
        [Builder.Object]
        private Button GtkB6;

        [Builder.Object]
        private Label GtkLabel;

        /// <summary> Connects to the InputText Control on the Glade Window. </summary>
        [Builder.Object]
        private Entry GtkEntry_Result;
        [Builder.Object]
        private Entry GtkEntry_Subject;

        [Builder.Object]
        private ComboBox GtkCombo;

        Gtk.ListStore store = new Gtk.ListStore(typeof(string), typeof(string));

        Dictionary<String,List<int>> keyValues = new Dictionary<string, List<int>>();

#pragma warning restore 649

        #endregion

        #region Constructors / Destructors
        /// <summary> Default Shared Constructor. </summary>
        /// <returns> A TestForm1. </returns>
        public static MainWindow Create()
        {
             
            Builder builder = new Builder(null, "ExampleApp1.gtk.glade", null);
            return new MainWindow(builder, builder.GetObject("MainWindow").Handle);
        }

        /// <summary> Specialised constructor for use only by derived class. </summary>
        /// <param name="builder"> The builder. </param>
        /// <param name="handle">  The handle. </param>
        protected MainWindow(Builder builder, IntPtr handle) : base(handle)
        {
            _builder = builder;
            builder.Autoconnect(this);
            SetupHandlers();
        }
        #endregion

        #region Handlers

        /// <summary> Sets up the handlers. </summary>
        protected void SetupHandlers()
        {

            GtkCombo.Model = store;
            CellRendererText cell = new CellRendererText();
            GtkCombo.PackStart(cell, true);
            GtkCombo.AddAttribute(cell, "text", 0);
            
            DeleteEvent += OnLocalDeleteEvent;
            GtkButton_Calculate.Clicked += GtkButton_Calculate_clicked_cb;
            GtkButton_AddSubject.Clicked += GtkButton_AddSubject_clicked_cb;
            GtkB1.Clicked += GtkB1_Clicked;
            GtkB2.Clicked += GtkB1_Clicked;
            GtkB3.Clicked += GtkB1_Clicked;
            GtkB4.Clicked += GtkB1_Clicked;
            GtkB5.Clicked += GtkB1_Clicked;
            GtkB6.Clicked += GtkB1_Clicked;
            GtkCombo.Changed += GtkCombo_Changed;
        }

        private void GtkB1_Clicked(object sender, EventArgs e)
        {
            if (GtkCombo.GetActiveIter(out TreeIter t))
            {
                if(keyValues.TryGetValue(store.GetValue(t, 0).ToString(),out List<int> marks))
                {
                    marks.Add(Int32.Parse((sender as Button).Label));

                    GtkLabel.Text = "";
                    foreach (int i in marks)
                    {
                        GtkLabel.Text += i.ToString() + " ";
                    }
                }
            }
        }

        private void GtkCombo_Changed(object sender, EventArgs e)
        {
            if (GtkCombo.GetActiveIter(out TreeIter t))
            {
                if (keyValues.TryGetValue(store.GetValue(t, 0).ToString(), out List<int> marks))
                {
                    GtkLabel.Text = "";
                    foreach(int i in marks)
                    {
                        GtkLabel.Text += i.ToString() + " ";
                    }
                }
            }
        }

        /// <summary> Handle Close of Form, Quit Application. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="a">      Event information to send to registered event handlers. </param>
        protected void OnLocalDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        /// <summary> Handle Click of Button. </summary>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="a">      Event information to send to registered event handlers. </param>

        protected void GtkButton_Calculate_clicked_cb(object sender, EventArgs a)
        {
            if (GtkCombo.GetActiveIter(out TreeIter t))
            {
                string subject = store.GetValue(t, 0).ToString();
                if (keyValues.TryGetValue(subject, out List<int> marks))
                {
                    float average = 0;
                    foreach (int i in marks)
                    {
                        average += i;
                    }
                    average = average / marks.Count;
                    GtkEntry_Result.Text = "Średnia z przedmiotu " + subject + " wynosi " + average.ToString();
                }
            }
        }
        protected void GtkButton_AddSubject_clicked_cb(object sender, EventArgs a)
        {
            if (GtkEntry_Subject.Text != null && !keyValues.ContainsKey(GtkEntry_Subject.Text))
            {
                store.AppendValues(GtkEntry_Subject.Text);
                keyValues.Add(GtkEntry_Subject.Text, new List<int>());
            }
            else {
                MessageDialog message = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Taki przedmiot juz istnieje");
                int result = message.Run();
                if (result == (int)Gtk.ResponseType.Ok)
                    message.Dispose();                
            } 
        }
        #endregion

    }
}