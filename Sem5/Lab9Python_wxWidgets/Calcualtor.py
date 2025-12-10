import wx
import os

class MainWindow(wx.Frame):
    def __init__(self, parent):
        self.last_button_pressed=''

        self.sizer = wx.BoxSizer(wx.VERTICAL)
        wx.Frame.__init__(self, parent, title="Lab9wxWidgets", size=(-1,-1))
        self.t3 = wx.TextCtrl(self,size = (30,30),style = wx.TE_READONLY)
        self.CreateStatusBar()
        self.sizer.Add(self.t3,0,wx.EXPAND|wx.ALL,10)


        filemenu = wx.Menu()
        menuHelp = filemenu.Append(wx.ID_HELP, "&Pomoc"," Kliknij aby uzyskać pomoc")
        menuExit = filemenu.Append(wx.ID_EXIT,"&Zakoncz"," Kliknij aby zakonczyc program")

        menuBar = wx.MenuBar()
        menuBar.Append(filemenu,"&Program")
        self.SetMenuBar(menuBar)

        self.Bind(wx.EVT_MENU, self.OnExit, menuExit)
        self.Bind(wx.EVT_MENU, self.OnHelp, menuHelp)





        buttons = [['7', '8', '9', '/'],
                   ['4', '5', '6', '*'],
                   ['1', '2', '3', '-'],
                   ['C', '0', '=', '+']]


        for labels in buttons:
            btn_sizer = wx.BoxSizer()
            for label in labels:
                button = wx.Button(self, label=label)
                btn_sizer.Add(button, 1, wx.ALIGN_CENTER|wx.EXPAND, 0)
                button.Bind(wx.EVT_BUTTON, self.on_Click)
            self.sizer.Add(btn_sizer, 1, wx.ALIGN_CENTER|wx.EXPAND)




        #Layout sizers
        self.SetSizer(self.sizer)
        self.SetAutoLayout(1)
        self.sizer.Fit(self)
        self.Show()

    def OnHelp(self,e):
        dlg = wx.MessageBox("Nie ma tutaj nic ciekawego","Pomoc?")


    def OnExit(self,e):
        dlg = wx.MessageDialog(self,"Na prawde chcesz wyjsc?", "Wyjscie", wx.YES_NO)
        res = dlg.ShowModal()
        dlg.Destroy()
        if res == wx.ID_YES:
            self.Close()


    def on_Click(self,e):
        operators = ['=' , 'C']
        operators_2 = ['+','-','/','*']
        label = e.GetEventObject().GetLabel()
        operator_pressed_twice = False
        if self.last_button_pressed in operators_2 and label in operators_2 :
            operator_pressed_twice = True

        if label not in operators:
            if operator_pressed_twice == False:
                self.t3.SetValue(self.t3.GetValue()+label)

        self.last_button_pressed = label

        if str(self.last_button_pressed) == "=":
            try:
                result = eval(self.t3.GetValue())
                self.t3.SetValue(str(result))
            except Exception as e:
                wx.LogError(str(e))
                return

        if str(self.last_button_pressed) == "C":
            self.t3.SetValue(" ")

app = wx.App(False)
frame = MainWindow(None)
app.MainLoop()