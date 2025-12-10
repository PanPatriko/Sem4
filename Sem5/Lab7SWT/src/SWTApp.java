import org.eclipse.swt.SWT;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.layout.FillLayout;
import org.eclipse.swt.layout.GridData;
import org.eclipse.swt.layout.GridLayout;
import org.eclipse.swt.layout.RowLayout;
import org.eclipse.swt.widgets.*;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Event;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Menu;
import org.eclipse.swt.widgets.MenuItem;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.List;

public class SWTApp {

    public static void main (String [] args) {
        Display display = new Display ();
        Shell shell = new Shell(display);
        shell.setText("Lab7SWT");

        GridLayout gridLayout = new GridLayout();
        gridLayout.numColumns = 2;
        shell.setLayout(gridLayout);

        Menu menuBar, fileMenu, helpMenu;
        MenuItem fileMenuHeader, helpMenuHeader;
        MenuItem fileExitItem,  helpGetHelpItem;
        menuBar = new Menu(shell, SWT.BAR);

        fileMenuHeader = new MenuItem(menuBar, SWT.CASCADE);
        fileMenuHeader.setText("&Program");

        fileMenu = new Menu(shell, SWT.DROP_DOWN);
        fileMenuHeader.setMenu(fileMenu);

        fileExitItem = new MenuItem(fileMenu, SWT.PUSH);
        fileExitItem.setText("Zakoncz");

        helpMenuHeader = new MenuItem(menuBar, SWT.CASCADE);
        helpMenuHeader.setText("&Pomoc");

        helpMenu = new Menu(shell, SWT.DROP_DOWN);
        helpMenuHeader.setMenu(helpMenu);

        helpGetHelpItem = new MenuItem(helpMenu, SWT.PUSH);
        helpGetHelpItem.setText("&Jaka pomoc?");

        fileExitItem.addSelectionListener(new SelectionAdapter() {
            @Override
            public void widgetSelected(SelectionEvent selectionEvent) {
                MessageBox mbox = new MessageBox(shell,SWT.YES|SWT.NO| SWT.ICON_QUESTION);
                mbox.setMessage("Czy na pewno chcesz wyjsc z programu?");
                int response = mbox.open();
                if (response == SWT.YES) {
                    shell.close();
                }            }
        });

        DateTime dt = new DateTime(shell, SWT.CALENDAR);
        GridData gridData = new GridData();
        gridData.verticalAlignment = GridData.FILL;
        gridData.horizontalSpan = 2;
        gridData.horizontalAlignment = GridData.FILL;
        gridData.grabExcessHorizontalSpace = true;
       // gridData.grabExcessVerticalSpace = true;
        dt.setLayoutData(gridData);


        GridData groupsGridData = new GridData();
        groupsGridData.verticalAlignment = GridData.FILL;
        groupsGridData.horizontalAlignment = GridData.FILL;
        groupsGridData.grabExcessHorizontalSpace = true;
        groupsGridData.grabExcessVerticalSpace = true;

        Group g1 = new Group(shell,SWT.SHADOW_ETCHED_IN);
        g1.setLayout(new FillLayout(SWT.VERTICAL));
        g1.setLayoutData(groupsGridData);
        g1.setText("Ryby");

        Combo combo = new Combo(g1, SWT.DROP_DOWN | SWT.READ_ONLY);

        Fish[] fishes = new Fish[]{ new Fish("Amur","Brak","Brak"),
                                    new Fish("Belona","Brak","Brak"),
                                    new Fish("Bolen","40 cm","od 1 stycznia do 30 kwietnia. Limit: 3 szt na dobę"),
                                    new Fish("Brzanka","40 cm ","od 1 stycznia do 30 czerwca"),
                                    new Fish("Ciernik","Brak","Brak"),
                                    new Fish("Ciosa","Każdy","Całkowity zakaz połowów")};

        String[] fishesTypes = new String[] { "Amur", "Belona","Bolen","Brzanka","Ciernik","Ciosa" };

        combo.setItems(fishesTypes);
        Label l1 = new Label(g1, SWT.BORDER);
        Label l2 = new Label(g1, SWT.BORDER);
        Label l3 = new Label(g1, SWT.BORDER);
        combo.addSelectionListener(new SelectionAdapter() {
            @Override
            public void widgetSelected(SelectionEvent selectionEvent) {

                int id = combo.getSelectionIndex();
                String fish = combo.getItem(id);
                for (Fish f: fishes)
                {
                    if(f.getType().equals(fish))
                    {
                        l1.setText("Nazwa: "+f.getType());
                        l2.setText("Rozmiar ochronny: "+f.getSize());
                        l3.setText("Okres ochronny: "+f.getProtectTime());
                        //    l1.pack();
                        //    l2.pack();
                        //    l3.pack();
                        shell.redraw();
                    }
                }
            }
        });

        //    g1.setLayoutData(gridData2);
        Group g2 = new Group(shell,SWT.SHADOW_ETCHED_IN);
        g2.setLayout(new GridLayout());
        g2.setLayoutData(groupsGridData);
        g2.setText("Notatki");

        List<String> notes = new ArrayList<>();

        Text noteArea = new Text(g2,SWT.BORDER | SWT.H_SCROLL | SWT.V_SCROLL | SWT.WRAP);
        noteArea.setLayoutData(new GridData(GridData.FILL_BOTH));

        Button saveButton = new Button(g2,SWT.PUSH);
        GridData buttongridData = new GridData();
        buttongridData.widthHint = 140;
        buttongridData.heightHint = 30;
        saveButton.setText("Zapisz");
        saveButton.setLayoutData(buttongridData);


        Table noteTable = new Table(g2,SWT.BORDER);
        noteTable.setLayoutData(new GridData(GridData.FILL_BOTH));
        TableColumn tc1 = new TableColumn(noteTable, SWT.CENTER);
        TableColumn tc2 = new TableColumn(noteTable, SWT.CENTER);
        tc1.setText("ID");
        tc2.setText("Data");
        tc1.setWidth(25);
        tc2.setWidth(75);
        noteTable.setHeaderVisible(true);

        saveButton.addSelectionListener(new SelectionAdapter() {
            @Override
            public void widgetSelected(SelectionEvent selectionEvent) {
                notes.add(noteArea.getText());
                TableItem item = new TableItem(noteTable, SWT.NONE);
                String data = String.valueOf(dt.getDay()) + "/" + String.valueOf(dt.getMonth()+1) + "/" + String.valueOf(dt.getYear());
                item.setText(new String[] { String.valueOf(notes.size()),data});
            }
        });

         noteTable.addListener(SWT.Selection, new Listener() {
            public void handleEvent(Event event) {

                int id = noteTable.getSelectionIndex();
                TableItem item = noteTable.getItem(id);
                String [] values = (item.getText(1).split("/"));
                dt.setDate(Integer.valueOf(values[2]),Integer.valueOf(values[1])-1,Integer.valueOf(values[0]));
                dt.redraw();
                noteArea.setText(notes.get(noteTable.getSelectionIndex()));
            }
        });


        //     g2.setLayoutData(gridData2);
        shell.setMenuBar(menuBar);
        shell.pack();
        shell.open ();
        while (!shell.isDisposed ()) {
            if (!display.readAndDispatch ()) display.sleep ();
        }
        display.dispose ();
    }
}
