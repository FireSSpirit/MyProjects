#pragma once
#include <iostream>
#include <string>
#include <fstream>
#include "Author.h"
#include "Helptxt.h"
#include "Books_and_other_informations.h"
namespace Information {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;
	int k = 0;
	Helptxt clear;
	Author author;
	Country From;
	Style style;
	Language language;
	Edition edition;
	Publishing publishing;
	Books book;
	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
			
			ifstream fin;
			fin.open("InformationsAboutAuthors.txt");
			if (!fin.is_open())
			{
				ofstream fin("InformationsAboutAuthors.txt");
			}
			else
			{
				char ch, chfull[100];
				for (int l1 = 0; l1 < 100; l1++)
				{
					chfull[l1] = 0;
				}
				int l = 0, i = 0;
				Helptxt *help = new Helptxt;
				while (!fin.eof())
				{
					dataGridView1->Rows->Add();
					while (fin.get(ch))
					{
						if (ch == '\n')
						{
							chfull[l] = 0;
							break;
						}
						else
						{
							if (ch != '/')
							{
								chfull[l] = ch;
								l++;
							}
							else
							{
								help->gimme = chfull;								
								i++;
								dataGridView1->Rows[k]->Cells[i]->Value = gcnew System::String(help->gimme.c_str());
								help->gimme = "";
								for (int l1 = 0; l1 < 100; l1++)
								{
									chfull[l1] = 0;
								}
								l = 0;
							}
						}
					}
					if (i == 7)
					{
						dataGridView1->Rows[k]->Cells[0]->Value = k + 1;
						k++;
						l = 0;
						i = 0;
					}
					else
					{
							for (int j = 0; j < i+1; j++)
							{
								dataGridView1->Rows[k]->Cells[j]->Value = "";
							}
							MessageBox::Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Warning);
							break;
						}
				}
			}

			fin.close();
	
		}
	
	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:
	private: System::Windows::Forms::DataGridView^  dataGridView1;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::Label^  FIO;
	private: System::Windows::Forms::Label^  Books;
	private: System::Windows::Forms::Label^  Style;
	private: System::Windows::Forms::Label^  Country;




	private: System::Windows::Forms::Button^  button1;


	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::TextBox^  textBox3;
	private: System::Windows::Forms::TextBox^  textBox4;
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::TextBox^  textBox7;
	private: System::Windows::Forms::TextBox^  textBox6;
	private: System::Windows::Forms::TextBox^  textBox5;
	private: System::Windows::Forms::Label^  Publishing;

	private: System::Windows::Forms::Label^  Edition;

	private: System::Windows::Forms::Label^  Language;















	private: System::Windows::Forms::Button^  button4;

private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column1;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column2;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column3;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column4;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column5;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column6;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column7;
private: System::Windows::Forms::DataGridViewTextBoxColumn^  Column8;
private: System::Windows::Forms::Button^  button2;
private: System::Windows::Forms::Button^  button3;












	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->Column1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column2 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column3 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column4 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column5 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column6 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column7 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Column8 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->FIO = (gcnew System::Windows::Forms::Label());
			this->Books = (gcnew System::Windows::Forms::Label());
			this->Style = (gcnew System::Windows::Forms::Label());
			this->Country = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox7 = (gcnew System::Windows::Forms::TextBox());
			this->textBox6 = (gcnew System::Windows::Forms::TextBox());
			this->textBox5 = (gcnew System::Windows::Forms::TextBox());
			this->Publishing = (gcnew System::Windows::Forms::Label());
			this->Edition = (gcnew System::Windows::Forms::Label());
			this->Language = (gcnew System::Windows::Forms::Label());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->groupBox1->SuspendLayout();
			this->SuspendLayout();
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(8) {
				this->Column1,
					this->Column2, this->Column3, this->Column4, this->Column5, this->Column6, this->Column7, this->Column8
			});
			this->dataGridView1->Location = System::Drawing::Point(470, 34);
			this->dataGridView1->Margin = System::Windows::Forms::Padding(4);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowTemplate->Height = 24;
			this->dataGridView1->Size = System::Drawing::Size(904, 385);
			this->dataGridView1->TabIndex = 1;
			// 
			// Column1
			// 
			this->Column1->HeaderText = L"№";
			this->Column1->Name = L"Column1";
			this->Column1->ReadOnly = true;
			this->Column1->Width = 30;
			// 
			// Column2
			// 
			this->Column2->HeaderText = L"Автор";
			this->Column2->Name = L"Column2";
			this->Column2->ReadOnly = true;
			this->Column2->Width = 130;
			// 
			// Column3
			// 
			this->Column3->HeaderText = L"Произведение";
			this->Column3->Name = L"Column3";
			this->Column3->ReadOnly = true;
			this->Column3->Width = 150;
			// 
			// Column4
			// 
			this->Column4->HeaderText = L"Жанр";
			this->Column4->Name = L"Column4";
			this->Column4->ReadOnly = true;
			// 
			// Column5
			// 
			this->Column5->HeaderText = L"Страна";
			this->Column5->Name = L"Column5";
			this->Column5->ReadOnly = true;
			// 
			// Column6
			// 
			this->Column6->HeaderText = L"Язык";
			this->Column6->Name = L"Column6";
			this->Column6->ReadOnly = true;
			this->Column6->Width = 120;
			// 
			// Column7
			// 
			this->Column7->HeaderText = L"Тираж";
			this->Column7->Name = L"Column7";
			this->Column7->ReadOnly = true;
			this->Column7->Width = 80;
			// 
			// Column8
			// 
			this->Column8->HeaderText = L"Издательство";
			this->Column8->Name = L"Column8";
			this->Column8->ReadOnly = true;
			this->Column8->Width = 150;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(238, 51);
			this->textBox1->Margin = System::Windows::Forms::Padding(4);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(181, 27);
			this->textBox1->TabIndex = 2;
			// 
			// FIO
			// 
			this->FIO->AutoSize = true;
			this->FIO->Location = System::Drawing::Point(8, 54);
			this->FIO->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->FIO->Name = L"FIO";
			this->FIO->Size = System::Drawing::Size(66, 20);
			this->FIO->TabIndex = 3;
			this->FIO->Text = L"Автор";
			// 
			// Books
			// 
			this->Books->AutoSize = true;
			this->Books->Location = System::Drawing::Point(8, 102);
			this->Books->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Books->Name = L"Books";
			this->Books->Size = System::Drawing::Size(145, 20);
			this->Books->TabIndex = 4;
			this->Books->Text = L"Произведение";
			// 
			// Style
			// 
			this->Style->AutoSize = true;
			this->Style->Location = System::Drawing::Point(8, 148);
			this->Style->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Style->Name = L"Style";
			this->Style->Size = System::Drawing::Size(57, 20);
			this->Style->TabIndex = 5;
			this->Style->Text = L"Жанр";
			// 
			// Country
			// 
			this->Country->AutoSize = true;
			this->Country->Location = System::Drawing::Point(8, 194);
			this->Country->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Country->Name = L"Country";
			this->Country->Size = System::Drawing::Size(77, 20);
			this->Country->TabIndex = 6;
			this->Country->Text = L"Страна";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(13, 436);
			this->button1->Margin = System::Windows::Forms::Padding(4);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(285, 62);
			this->button1->TabIndex = 7;
			this->button1->Text = L"Добавить сведения";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(238, 99);
			this->textBox2->Margin = System::Windows::Forms::Padding(4);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(181, 27);
			this->textBox2->TabIndex = 10;
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(238, 145);
			this->textBox3->Margin = System::Windows::Forms::Padding(4);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(181, 27);
			this->textBox3->TabIndex = 11;
			// 
			// textBox4
			// 
			this->textBox4->Location = System::Drawing::Point(238, 191);
			this->textBox4->Margin = System::Windows::Forms::Padding(4);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(181, 27);
			this->textBox4->TabIndex = 12;
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->textBox7);
			this->groupBox1->Controls->Add(this->textBox6);
			this->groupBox1->Controls->Add(this->textBox5);
			this->groupBox1->Controls->Add(this->Publishing);
			this->groupBox1->Controls->Add(this->Edition);
			this->groupBox1->Controls->Add(this->Language);
			this->groupBox1->Controls->Add(this->textBox1);
			this->groupBox1->Controls->Add(this->textBox4);
			this->groupBox1->Controls->Add(this->FIO);
			this->groupBox1->Controls->Add(this->textBox3);
			this->groupBox1->Controls->Add(this->Books);
			this->groupBox1->Controls->Add(this->textBox2);
			this->groupBox1->Controls->Add(this->Style);
			this->groupBox1->Controls->Add(this->Country);
			this->groupBox1->Location = System::Drawing::Point(13, 34);
			this->groupBox1->Margin = System::Windows::Forms::Padding(4);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Padding = System::Windows::Forms::Padding(4);
			this->groupBox1->Size = System::Drawing::Size(432, 385);
			this->groupBox1->TabIndex = 13;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Сведения";
			// 
			// textBox7
			// 
			this->textBox7->Location = System::Drawing::Point(238, 332);
			this->textBox7->Name = L"textBox7";
			this->textBox7->Size = System::Drawing::Size(181, 27);
			this->textBox7->TabIndex = 18;
			// 
			// textBox6
			// 
			this->textBox6->Location = System::Drawing::Point(238, 283);
			this->textBox6->Name = L"textBox6";
			this->textBox6->Size = System::Drawing::Size(181, 27);
			this->textBox6->TabIndex = 17;
			// 
			// textBox5
			// 
			this->textBox5->Location = System::Drawing::Point(238, 240);
			this->textBox5->Name = L"textBox5";
			this->textBox5->Size = System::Drawing::Size(181, 27);
			this->textBox5->TabIndex = 16;
			// 
			// Publishing
			// 
			this->Publishing->AutoSize = true;
			this->Publishing->Location = System::Drawing::Point(8, 335);
			this->Publishing->Name = L"Publishing";
			this->Publishing->Size = System::Drawing::Size(142, 20);
			this->Publishing->TabIndex = 15;
			this->Publishing->Text = L"Издательство";
			// 
			// Edition
			// 
			this->Edition->AutoSize = true;
			this->Edition->Location = System::Drawing::Point(8, 286);
			this->Edition->Name = L"Edition";
			this->Edition->Size = System::Drawing::Size(66, 20);
			this->Edition->TabIndex = 14;
			this->Edition->Text = L"Тираж";
			// 
			// Language
			// 
			this->Language->AutoSize = true;
			this->Language->Location = System::Drawing::Point(8, 243);
			this->Language->Name = L"Language";
			this->Language->Size = System::Drawing::Size(56, 20);
			this->Language->TabIndex = 13;
			this->Language->Text = L"Язык";
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(910, 446);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(207, 52);
			this->button4->TabIndex = 15;
			this->button4->Text = L"Очистить список";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::button4_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(470, 446);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(160, 52);
			this->button2->TabIndex = 17;
			this->button2->Text = L"Количество книг";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(1166, 446);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(208, 48);
			this->button3->TabIndex = 18;
			this->button3->Text = L"Сохранить и выйти";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(11, 20);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1387, 572);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->groupBox1);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->dataGridView1);
			this->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"MyForm";
			this->Text = L"Ввод и вывод данных";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
		private: std::string GetString(String ^ s)
		{
			std::string os;
			using namespace Runtime::InteropServices;
			const char* chars =
				(const char*)(Marshal::StringToHGlobalAnsi(s)).ToPointer();
			os = chars;
			Marshal::FreeHGlobal(IntPtr((void*)chars));
			return os;
		}
private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
	if ((textBox1->Text == "") || (textBox2->Text == "") || (textBox3->Text == "") || (textBox4->Text == "") || (textBox5->Text == "")
		|| (textBox6->Text == "") || (textBox7->Text == ""))
	{
		MessageBox::Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Warning);
	}
	else
	{		
		int t = 0;
		author.name = GetString(textBox1->Text);
		book.name = GetString(textBox2->Text);
		book.be();
		style.name = GetString(textBox3->Text);
		From.name = GetString(textBox4->Text);
		language.name = GetString(textBox5->Text);
		edition.name = GetString(textBox6->Text);
		publishing.name = GetString(textBox7->Text);
		if (author.Correct(author.name))
		{
			if (style.Correct(style.name))
			{
				if (From.Correct(From.name))
				{
					if (language.Correct(language.name))
					{
						if (edition.Correct(edition.name))
						{
							if (publishing.Correct(publishing.name))
							{
								t = 1;
								dataGridView1->Rows->Add();
								dataGridView1->Rows[k]->Cells[0]->Value = k + 1;
								dataGridView1->Rows[k]->Cells[1]->Value = textBox1->Text;
								dataGridView1->Rows[k]->Cells[2]->Value = textBox2->Text;
								dataGridView1->Rows[k]->Cells[3]->Value = textBox3->Text;
								dataGridView1->Rows[k]->Cells[4]->Value = textBox4->Text;
								dataGridView1->Rows[k]->Cells[5]->Value = textBox5->Text;
								dataGridView1->Rows[k]->Cells[6]->Value = textBox6->Text;
								dataGridView1->Rows[k]->Cells[7]->Value = textBox7->Text;
								MessageBox::Show("Сведения добавлены", "Успешно", MessageBoxButtons::OK, MessageBoxIcon::Asterisk);
								ofstream fout;
								fstream file("InformationsAboutAuthors.txt");
								fout.open("InformationsAboutAuthors.txt", ofstream ::app);
								Helptxt sl;
								if ( file.peek() != EOF)
								fout << sl.down << author.name << sl.slesh << book.name << sl.slesh << style.name << sl.slesh 
									<< From.name << sl.slesh << language.name << sl.slesh << edition.name << sl.slesh 
									<< publishing.name << sl.slesh;
								else
									fout << author.name << sl.slesh << book.name << sl.slesh << style.name << sl.slesh 
									<< From.name << sl.slesh << language.name << sl.slesh << edition.name << sl.slesh
									<< publishing.name << sl.slesh;
								fout.close();
								textBox1->Text = "";
								textBox2->Text = "";
								textBox3->Text = "";
								textBox4->Text = "";
								textBox5->Text = "";
								textBox6->Text = "";
								textBox7->Text = "";
							}
						}
					}
				}
			}
		}
		if (t == 0)
		{
			MessageBox::Show("Некорректные введенные значения!", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Warning);
			k--;
		}
		k++;
	}
}
		 
private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
	dataGridView1->Rows->Clear();
	clear.Clear();
	k = 0;
}				 
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
	MessageBox::Show("Всего книг: " + k, "Книги", MessageBoxButtons::OK);
}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
	exit(0);
}
};

}
