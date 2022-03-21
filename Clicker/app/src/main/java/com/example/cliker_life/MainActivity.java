package com.example.cliker_life;

import android.content.Intent;
import android.content.SharedPreferences;
import android.preference.Preference;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.TextView;

import java.util.Random;

public class MainActivity extends AppCompatActivity {
    static public int coutmoney = 0;
    static public int money = 100;
    static public int home_money = 0, city_money = 0;
    static public Button next_day, improve, event;
    static public TextView textmoney, home, city;
    final Random random = new Random();
    public int r = 0;
    //SharedPreferences preferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        next_day = (Button)findViewById(R.id.next_day);
        improve = (Button)findViewById(R.id.improve);
        textmoney = (TextView)findViewById(R.id.money);
        home = (TextView)findViewById(R.id.home);
        city = (TextView)findViewById(R.id.city);
        event = (Button)findViewById(R.id.event);
        Saved.init(getApplicationContext());
        new Saved().load_save();
        Next_day();

    }
    void Switch_Buttons()
    {
        event.setVisibility(View.VISIBLE);
        event.setClickable(true);
        next_day.setClickable(false);
        next_day.setVisibility(View.INVISIBLE);
    }
    void Again()
    {
        home_money = 0;
        city_money = 0;
        money = 100;
        coutmoney = 0;
        Improve.price1 = 500;
    }
    void Next_day(){
        next_day.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                    r = random.nextInt(30);
                    if (r == 5)
                    {
                        Switch_Buttons();
                        event.setText("Дополнительные налоги: 300");
                        city_money += 300;
                    }
                    else if (r == 11)
                    {
                        Switch_Buttons();
                        event.setText("Дополнительные личные расходы: 200");
                        home_money += 200;
                    }
                    else if (r == 17)
                    {
                        Switch_Buttons();
                        event.setText("Премия на работе: 250");
                        coutmoney += 250;
                    }

                        coutmoney += money;
                        textmoney.setText(coutmoney + "");
                        home_money += 25;
                        city_money += 50;
                        home.setText("Потребности:\n" + home_money);
                        city.setText("Налоги:\n" + city_money);

                        if (city_money >= 1000)
                        {
                            Switch_Buttons();
                            event.setText("Увы! Вы проиграли! Налоги не уплачены!");
                            Again();
                        }

                        if (home_money >= 1000)
                        {
                            Switch_Buttons();
                            event.setText("Увы! Вы проиграли! Личные расходы не уплачены!");
                            Again();
                        }

                        if (coutmoney >= 100000)
                        {
                            Switch_Buttons();
                            event.setText("Вы победили! Вам удалось собрать лучший компьютер!");
                            Again();
                        }

                        new Saved().save();
            }
        });
        improve.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, Improve.class);
                startActivity(intent);
            }
        });
        event.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                event.setVisibility(View.INVISIBLE);
                event.setClickable(false);
                next_day.setClickable(true);
                next_day.setVisibility(View.VISIBLE);
            }
        });

    }

}
