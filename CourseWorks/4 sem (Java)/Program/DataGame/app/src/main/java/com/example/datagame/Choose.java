package com.example.datagame;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

public class Choose extends AppCompatActivity {

    public static String EXTRA_MESSAGE;
    public final static String EXTRA_MESSAGE1 = "EXTRA_MESSAGE1";
    public final static String EXTRA_MESSAGE2 = "EXTRA_MESSAGE2";

    public void sendMessage1(View view, String m) {
        EXTRA_MESSAGE = EXTRA_MESSAGE1;
        Intent intent = new Intent(this, EndActivity.class);
        intent.putExtra(EXTRA_MESSAGE, m);
        startActivity(intent);
    }

    public void sendMessage2(View view, String m) {

        EXTRA_MESSAGE = EXTRA_MESSAGE2;
        Intent intent = new Intent(this, EndActivity.class);
        intent.putExtra(EXTRA_MESSAGE, m);
        startActivity(intent);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Intent intent = getIntent();
        Bundle arguments = getIntent().getExtras();

        final String message = arguments.get(MainActivity.EXTRA_MESSAGE).toString();

        setContentView(R.layout.activity_choose);
//       TextView textView = new TextView(this);
//        textView.setText(name);
//
//        TextView editText = (TextView) findViewById(R.id.textView3);
//        editText.setText(textView.getText());

  //      final int message = intent.getIntExtra(MainActivity.EXTRA_MESSAGE,-1);

        final Button button1 = (Button) findViewById(R.id.button);
        button1.setOnClickListener(new ImageButton.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendMessage1(view, message);
            }

        });


        final Button button2 = (Button) findViewById(R.id.button3);
        button2.setOnClickListener(new ImageButton.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendMessage2(view, message);
            }

        });


    }
}
