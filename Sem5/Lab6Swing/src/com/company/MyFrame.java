package com.company;
import javafx.scene.control.RadioButton;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import java.awt.geom.Rectangle2D;
import java.util.Scanner;
import javax.swing.*;
class MyFrame extends JFrame   {

    JPanel rightPanel;
    JPanel leftPanel;
    JPanel topPanel;
    JPanel centerPanel;

    public MyFrame() {

        super("Swing Lab6");

        setSize(400,600);

        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
        setLayout(new BorderLayout());

        JRadioButton R1 = new JRadioButton("R1");
        R1.setActionCommand("R1");
        JRadioButton R2 = new JRadioButton("R2");
        R2.setActionCommand("R2");
        JRadioButton R3 = new JRadioButton("R3");
        R3.setActionCommand("R3");
        JRadioButton R4 = new JRadioButton("R4");
        R4.setActionCommand("R4");
        JRadioButton R5 = new JRadioButton("R5");
        R5.setActionCommand("R5");
        JRadioButton R6 = new JRadioButton("R6");
        R6.setActionCommand("R6");

        ButtonGroup group1 = new ButtonGroup( );
        ButtonGroup group2 = new ButtonGroup( );

        group1.add(R1);
        group1.add(R2);
        group1.add(R3);
        group2.add(R4);
        group2.add(R5);
        group2.add(R6);

        JTextArea jTextArea = new JTextArea("TextArea");

        JButton jButton = new JButton();
        jButton.setText("JButton");
        jButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                String text = "";
                if(group1.getSelection()!=null)
                {
                    text = text + group1.getSelection().getActionCommand()+ " ";
                }
                if(group2.getSelection()!=null)
                {
                    text = text + group2.getSelection().getActionCommand();
                }
                jTextArea.setText(text);
            }
        });
        String[] Strings = { "1", "2"};
        JComboBox jComboBox = new JComboBox(Strings);
        jComboBox.addItemListener(new ItemListener() {
            @Override
            public void itemStateChanged(ItemEvent itemEvent) {
                CardLayout cl = (CardLayout) rightPanel.getLayout();
                cl.show(rightPanel, itemEvent.getItem().toString());
            }
        });

        topPanel = new JPanel();
        topPanel.setLayout(new FlowLayout());
        topPanel.setBorder(BorderFactory.createLineBorder(Color.black));
        topPanel.setComponentOrientation(
                ComponentOrientation.LEFT_TO_RIGHT);
        add(topPanel,BorderLayout.PAGE_START );

        for(int i =1;i<=15;i++)
        {
            topPanel.add(new JButton("Button"+i));
            // centerPanel.add(new JButton("Button"+i));
        }

        leftPanel = new JPanel();
        leftPanel.setLayout(new BoxLayout(leftPanel, BoxLayout.PAGE_AXIS));
        add(leftPanel,BorderLayout.LINE_START);
        leftPanel.setBorder(BorderFactory.createLineBorder(Color.black));
        leftPanel.add(jButton);
        leftPanel.add(jTextArea);
        leftPanel.add(new JCheckBox("CheckBox1"));
        leftPanel.add(new JCheckBox("CheckBox2"));
        leftPanel.add(jComboBox);

        centerPanel = new JPanel();
        GroupLayout layout = new GroupLayout(centerPanel);
        layout.setAutoCreateGaps(true);
        layout.setAutoCreateContainerGaps(true);
        layout.setHorizontalGroup(layout.createSequentialGroup()
                .addComponent(R1)
                .addComponent(R2)
                .addComponent(R3)
                .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(
                                GroupLayout.Alignment.LEADING)
                                .addComponent(R4)
                                .addComponent(R5)
                                .addComponent(R6)
                        )));
        layout.setVerticalGroup(layout.createSequentialGroup()
                .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(
                                GroupLayout.Alignment.LEADING)
                                .addComponent(R1)
                                .addComponent(R2)
                                .addComponent(R3)))
                .addComponent(R4)
                .addComponent(R5)
                .addComponent(R6)
        );
        centerPanel.setLayout(layout);
        centerPanel.setBorder(BorderFactory.createLineBorder(Color.black));
        add(centerPanel,BorderLayout.CENTER);

        rightPanel = new JPanel();
        rightPanel.setLayout(new CardLayout());
        rightPanel.setBorder(BorderFactory.createLineBorder(Color.black));

        JPanel card1 = new JPanel();
        card1.setLayout(new BoxLayout(card1, BoxLayout.LINE_AXIS));
        card1.add(new JButton("Button 1"));
        card1.add(new JButton("Button 2"));
        card1.add(new JButton("Button 3"));

        JPanel card2 = new JPanel();
        card2.setLayout(new BoxLayout(card2, BoxLayout.PAGE_AXIS));
        card2.add(new JTextField("TextField 1", 20));
        card2.add(new JTextField("TextField 2", 20));
        card2.add(new JTextField("TextField 3", 20));

        rightPanel.add(card1, "1");
        rightPanel.add(card2,"2");
        add(rightPanel,BorderLayout.LINE_END);

    }
}

