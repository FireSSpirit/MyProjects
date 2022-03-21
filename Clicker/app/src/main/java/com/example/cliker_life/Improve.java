package com.example.cliker_life;

import android.content.SharedPreferences;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Improve extends AppCompatActivity {
    Button laptop, home_price, city_price;
    public static Button color_blue, color_green, color_grey, color_violet;
    public static int price1 = 500;
    public static int price_blue = 10000;
    public static int price_green = 20000;
    public static int price_grey = 30000;
    public static int price_violet = 50000;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_improve);
        laptop = (Button) findViewById(R.id.laptop);
        home_price = (Button) findViewById(R.id.home_price);
        city_price = (Button) findViewById(R.id.city_price);
        color_blue = (Button) findViewById(R.id.color_blue);
        color_green = (Button) findViewById(R.id.color_green);
        color_grey = (Button) findViewById(R.id.color_grey);
        color_violet = (Button) findViewById(R.id.color_violet);

        laptop.setText("Улучшить мощность компьютера:\n" + price1 + " рублей");
        laptop.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= price1) {
                    MainActivity.money += 100;
                    MainActivity.coutmoney -= price1;
                    price1+=200;
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    laptop.setText("Улучшить мощность компьютера:\n" + price1 + " рублей");
                    new Saved().save();
                }
            }
        });
        city_price.setText("Оплатить налоги:\n" + MainActivity.city_money);
        city_price.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= MainActivity.city_money){
                    MainActivity.coutmoney -= MainActivity.city_money;
                    MainActivity.city_money = 0;
                    MainActivity.city.setText("Налоги:\n" + MainActivity.city_money);
                    city_price.setText("Оплатить налоги:\n" + MainActivity.city_money);
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    new Saved().save();
                }
            }
        });
        home_price.setText("Оплатить потребности:\n" + MainActivity.home_money);
        home_price.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= MainActivity.home_money){
                    MainActivity.coutmoney -= MainActivity.home_money;
                    MainActivity.home_money = 0;
                    home_price.setText("Оплатить потребности:\n" + MainActivity.home_money * 2);
                    MainActivity.home.setText("Потребности:\n" +  MainActivity.home_money);
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    new Saved().save();
                }
            }
        });
        if (price_blue == 0) color_blue.setText("Куплено");
        color_blue.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= price_blue){
                    MainActivity.coutmoney -= price_blue;
                    price_blue = 0;
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    color_blue.setText("Куплено");
                    MainActivity.next_day.setBackgroundColor(((ColorDrawable)color_blue.getBackground()).getColor());

                    new Saved().save();
                }
            }
        });
        if (price_green == 0) color_green.setText("Куплено");
        color_green.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= price_green){
                    MainActivity.coutmoney -= price_green;
                    price_green = 0;
                    color_green.setText("Куплено");
                    MainActivity.next_day.setBackgroundColor(((ColorDrawable)color_green.getBackground()).getColor());
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    new Saved().save();
                }
            }
        });
        if (price_grey == 0) color_grey.setText("Куплено");
        color_grey.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= price_grey){
                    MainActivity.coutmoney -= price_grey;
                    price_grey = 0;
                    color_grey.setText("Куплено");
                    MainActivity.next_day.setBackgroundColor(((ColorDrawable)color_grey.getBackground()).getColor());
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    new Saved().save();
                }
            }
        });
        if (price_violet == 0) color_violet.setText("Куплено");
        color_violet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (MainActivity.coutmoney >= price_violet){
                    MainActivity.coutmoney -= price_violet;
                    price_violet = 0;
                    color_violet.setText("Куплено");
                    MainActivity.next_day.setBackgroundColor(((ColorDrawable)color_violet.getBackground()).getColor());
                    MainActivity.textmoney.setText(MainActivity.coutmoney + "");
                    new Saved().save();
                }
            }
        });
    }
}
