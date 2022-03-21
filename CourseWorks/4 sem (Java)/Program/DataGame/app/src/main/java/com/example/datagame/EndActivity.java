package com.example.datagame;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;


public class EndActivity extends AppCompatActivity  {
    Game[][] games = new Game[4][3];
    final String data = "Год выхода: ";
    final String style = "Жанр: ";

    public void ClickUp(View view) {
        Global.a++;
    if (Global.a == 3) Global.a = 0;
    Choose();
     //   textView1.setText(games[i][k].name);
    }

    public void ClickDown(View view) {
        Global.a--;
        if (Global.a == -1) Global.a = 2;
        Choose();
    }

    void Choose()
    {
        TextView editText1 = (TextView) findViewById(R.id.nameOfGame);
        editText1.setText(games[Global.b][Global.a].name);

        TextView editText2 = (TextView) findViewById(R.id.styleGame);
        editText2.setText(style + games[Global.b][Global.a].description);

        TextView editText3 = (TextView) findViewById(R.id.yearRealize);
        editText3.setText(data + games[Global.b][Global.a].year);

        ImageView imageView = (ImageView) this.findViewById(R.id.imageView);
        imageView.setImageResource(games[Global.b][Global.a].view);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_end);
        Bundle arguments = getIntent().getExtras();

        String message;
        boolean soon = false;
        message =  arguments.get(Choose.EXTRA_MESSAGE).toString();
        if (Choose.EXTRA_MESSAGE == "EXTRA_MESSAGE2")
            soon = true;

        if (soon)
        {
            games[0][0] = new Game("Cyberpunk 2077", R.drawable.cyberpunk2077, "Экшн, РПГ, 1-ое лицо", "2020");
            games[0][1] = new Game("The Last of Us 2", R.drawable.lastofus2, "Экшн, приключение, стелс", "2020");
            games[0][2] = new Game("Ghost of Tsushima", R.drawable.ghostoftsushima,"Экшн, приключение, стелс","2020" );

            games[1][0] = games[0][0];
            games[1][1] = new Game("Halo Infinite", R.drawable.halo,"Шутер, 1-ое лицо","2020" );
            games[1][2] = new Game("Dying Light 2", R.drawable.dl2,"Экшн, РПГ, 1-ое лицо","2020" );

            games[2][0] = new Game("The Legend of Zelda: Breath of the Wild 2", R.drawable.zelda,"Экшн, приключение","2020" );
            games[2][1] = new Game("Metroid Prime 4", R.drawable.metroid,"Экшн","2020" );
            games[2][2] = new Game("No More Heroes 3", R.drawable.nomanheroes3,"Боевик","2020" );

            games[3][0] = games[0][0];
            games[3][1] = games[1][2];
            games[3][2] = new Game("Diablo 4", R.drawable.diablo4,"Экшн, РПГ, ММО","2021" );
        }
else
        {
            games[0][0] = new Game("God of War", R.drawable.godofwar, "Экшн, приключение", "2018");
            games[0][1] = new Game("The Last of Us", R.drawable.lastofus, "Экшн, приключение, стелс", "2013");
            games[0][2] = new Game("Horizon Zero Dawn", R.drawable.hzd,"Экшн, приключение, РПГ","2017" );

            games[1][0] = new Game("The Witcher 3", R.drawable.w3,"Экшн, РПГ","2015" );
            games[1][1] = new Game("Doom Eternal", R.drawable.doom,"Шутер, 1-ое лицо","2020" );
            games[1][2] = new Game("Geers 5", R.drawable.geers5,"Шутер, 3-ое лицо","2019" );

            games[2][0] = new Game("The Legend of Zelda: Breath of the Wild", R.drawable.zelda1,"Экшн, приключение","2017" );
            games[2][1] = new Game("The Witcher 3", R.drawable.w3,"Экшн, РПГ","2019" );
            games[2][2] = new Game("Animal Crossing: New Horizons", R.drawable.animal,"Симулятор жизни","2020" );

            games[3][0] = games[1][0];
            games[3][1] = new Game("Hearthstone", R.drawable.hs,"ККИ","2014" );
            games[3][2] = new Game("CS GO", R.drawable.csgo,"Шутер, 1-ое лицо","2012" );
        }

switch (message)
{
    case("1"):
        Global.b = 0;
        Choose();
        break;
    case("2"):
        Global.b = 1;
        Choose();
        break;
    case("3"):
        Global.b = 2;
        Choose();
        break;
    case("4"):
        Global.b = 3;
        Choose();
        break;
}

//        TextView textView = new TextView(this);
//        textView.setText(message);
//
//        TextView editText = (TextView) findViewById(R.id.textView2);
//        editText.setText(textView.getText());

    }
}
