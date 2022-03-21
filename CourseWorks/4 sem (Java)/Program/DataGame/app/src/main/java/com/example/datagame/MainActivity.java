package com.example.datagame;

import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;


public class MainActivity extends AppCompatActivity {
    int k = 0;
    public final static String EXTRA_MESSAGE = "EXTRA_MESSAGE";

  public void sendMessage(View view) {
      Intent intent = new Intent(this, Choose.class);
      intent.putExtra(EXTRA_MESSAGE, k);
      startActivity(intent);
  }

  @Override
    protected void onCreate(Bundle savedInstanceState) {
      super.onCreate(savedInstanceState);
      setContentView(R.layout.activity_main);

      final Animation animAlpha = AnimationUtils.loadAnimation(this, R.anim.alpha);

      final ImageButton btnAlpha1 = (ImageButton) findViewById(R.id.alpha1);
      btnAlpha1.setOnClickListener(new ImageButton.OnClickListener() {
          @Override
          public void onClick(View view) {
              view.startAnimation(animAlpha);
              Del(view,1);
          }

      });

      ImageButton btnAlpha2 = (ImageButton) findViewById(R.id.alpha2);
      btnAlpha2.setOnClickListener(new ImageButton.OnClickListener() {
          @Override
          public void onClick(View view) {
              view.startAnimation(animAlpha);
              Del(view,2);
          }
      });

      ImageButton btnAlpha3 = (ImageButton) findViewById(R.id.alpha3);
      btnAlpha3.setOnClickListener(new ImageButton.OnClickListener() {
          @Override
          public void onClick(View view) {
              view.startAnimation(animAlpha);
              Del(view,3);
          }
      });

      ImageButton btnAlpha4 = (ImageButton) findViewById(R.id.alpha4);
      btnAlpha4.setOnClickListener(new ImageButton.OnClickListener() {
          @Override
          public void onClick(View view) {
              view.startAnimation(animAlpha);
              Del(view,4);
          }
      });

  }

    public void Del(View view, int i) {
        final Button Finalbutton = (Button) findViewById(R.id.button2);
      Finalbutton.setVisibility(View.VISIBLE); // ИЗМЕНИТЬ !!!! ВСЕГДА ВИДНА КНОПКА!!!
        ImageButton btnAlpha1 = (ImageButton) findViewById(R.id.alpha1);
        ImageButton btnAlpha2 = (ImageButton) findViewById(R.id.alpha2);
        ImageButton btnAlpha3 = (ImageButton) findViewById(R.id.alpha3);
        ImageButton btnAlpha4 = (ImageButton) findViewById(R.id.alpha4);
        k = i;

//if (i == 1) {
//    btnAlpha2.setVisibility(View.GONE);
//    btnAlpha3.setVisibility(View.GONE);
//    btnAlpha4.setVisibility(View.GONE);
//}
//else if (i == 2) {
//    btnAlpha4.setVisibility(View.GONE);
//    btnAlpha1.setVisibility(View.GONE);
//    btnAlpha3.setVisibility(View.GONE);
//}
//else if (i == 3) {
//    btnAlpha1.setVisibility(View.GONE);
//    btnAlpha4.setVisibility(View.GONE);
//    btnAlpha2.setVisibility(View.GONE);
//}
//else {
//    btnAlpha1.setVisibility(View.GONE);
//    btnAlpha2.setVisibility(View.GONE);
//    btnAlpha3.setVisibility(View.GONE);
//}
        }




    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
