#pragma once
#include <iostream>
#include <string>
#include <fstream>
#include <vector>
namespace OperationsOfFrequencyDictionary {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;

	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;
	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	
	//fstream file("Dictionary.txt");
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
			fin.open("TODO.txt");
			if (!fin.is_open())
			{
				ofstream fin("TODO.txt");
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
	private: System::Windows::Forms::Button^  newDictionary;
	private: System::Windows::Forms::Button^  addWord;
	private: System::Windows::Forms::Button^  output;
	protected:



	private: System::Windows::Forms::Button^  searchWord;
	private: System::Windows::Forms::Button^  downloadFrom;


	private: System::Windows::Forms::ListBox^  listBox1;
	private: System::Windows::Forms::Button^  closePLS;

	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::Label^  label1;

	protected:

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
			this->newDictionary = (gcnew System::Windows::Forms::Button());
			this->addWord = (gcnew System::Windows::Forms::Button());
			this->output = (gcnew System::Windows::Forms::Button());
			this->searchWord = (gcnew System::Windows::Forms::Button());
			this->downloadFrom = (gcnew System::Windows::Forms::Button());
			this->listBox1 = (gcnew System::Windows::Forms::ListBox());
			this->closePLS = (gcnew System::Windows::Forms::Button());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// newDictionary
			// 
			this->newDictionary->Location = System::Drawing::Point(36, 45);
			this->newDictionary->Name = L"newDictionary";
			this->newDictionary->Size = System::Drawing::Size(223, 59);
			this->newDictionary->TabIndex = 0;
			this->newDictionary->Text = L"Создать пустой словарь";
			this->newDictionary->UseVisualStyleBackColor = true;
			this->newDictionary->Click += gcnew System::EventHandler(this, &MyForm::newDictionary_Click);
			// 
			// addWord
			// 
			this->addWord->Location = System::Drawing::Point(371, 45);
			this->addWord->Name = L"addWord";
			this->addWord->Size = System::Drawing::Size(261, 59);
			this->addWord->TabIndex = 1;
			this->addWord->Text = L"добавить новый элемент в словарь";
			this->addWord->UseVisualStyleBackColor = true;
			this->addWord->Click += gcnew System::EventHandler(this, &MyForm::addWord_Click);
			// 
			// output
			// 
			this->output->Location = System::Drawing::Point(36, 184);
			this->output->Name = L"output";
			this->output->Size = System::Drawing::Size(223, 48);
			this->output->TabIndex = 2;
			this->output->Text = L"вывод элементов словаря в алфавитном порядке";
			this->output->UseVisualStyleBackColor = true;
			this->output->Click += gcnew System::EventHandler(this, &MyForm::output_Click);
			// 
			// searchWord
			// 
			this->searchWord->Location = System::Drawing::Point(371, 116);
			this->searchWord->Name = L"searchWord";
			this->searchWord->Size = System::Drawing::Size(261, 50);
			this->searchWord->TabIndex = 3;
			this->searchWord->Text = L"поиск элемента словаря по слову.";
			this->searchWord->UseVisualStyleBackColor = true;
			this->searchWord->Click += gcnew System::EventHandler(this, &MyForm::searchWord_Click);
			// 
			// downloadFrom
			// 
			this->downloadFrom->Location = System::Drawing::Point(36, 116);
			this->downloadFrom->Name = L"downloadFrom";
			this->downloadFrom->Size = System::Drawing::Size(223, 52);
			this->downloadFrom->TabIndex = 4;
			this->downloadFrom->Text = L"Загрузить словарь из файла";
			this->downloadFrom->UseVisualStyleBackColor = true;
			this->downloadFrom->Click += gcnew System::EventHandler(this, &MyForm::downloadFrom_Click);
			// 
			// listBox1
			// 
			this->listBox1->BackColor = System::Drawing::SystemColors::HighlightText;
			this->listBox1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->listBox1->FormattingEnabled = true;
			this->listBox1->ItemHeight = 20;
			this->listBox1->Items->AddRange(gcnew cli::array< System::Object^  >(1) { L"Слово               Количество" });
			this->listBox1->Location = System::Drawing::Point(709, 12);
			this->listBox1->Name = L"listBox1";
			this->listBox1->Size = System::Drawing::Size(243, 424);
			this->listBox1->TabIndex = 5;
			// 
			// closePLS
			// 
			this->closePLS->Location = System::Drawing::Point(36, 251);
			this->closePLS->Name = L"closePLS";
			this->closePLS->Size = System::Drawing::Size(223, 46);
			this->closePLS->TabIndex = 6;
			this->closePLS->Text = L"Закрыть словарь";
			this->closePLS->UseVisualStyleBackColor = true;
			this->closePLS->Click += gcnew System::EventHandler(this, &MyForm::closePLS_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(422, 184);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(210, 22);
			this->textBox1->TabIndex = 7;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(368, 187);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(48, 17);
			this->label1->TabIndex = 8;
			this->label1->Text = L"Слово";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(964, 509);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->closePLS);
			this->Controls->Add(this->listBox1);
			this->Controls->Add(this->downloadFrom);
			this->Controls->Add(this->searchWord);
			this->Controls->Add(this->output);
			this->Controls->Add(this->addWord);
			this->Controls->Add(this->newDictionary);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

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

private: System::Void newDictionary_Click(System::Object^  sender, System::EventArgs^  e) {
	

}
private: System::Void downloadFrom_Click(System::Object^  sender, System::EventArgs^  e) {



		//		char ch, chfull[100];
			//	for (int l1 = 0; l1 < 100; l1++)
			//	{
			//		chfull[l1] = 0;
				//}
			//	int l = 0, i = 0;
				//Helptxt *help = new Helptxt;
			//	while (!fin.eof())
			//	{
			//		listBox1->Items->Add("Слово               количество");//15 пробелов
			/*		while (fin.get(ch))
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
							//	help->gimme = chfull;
								i++;
							//	dataGridView1->Rows[k]->Cells[i]->Value = gcnew System::String(help->gimme.c_str());
							//	help->gimme = "";
								for (int l1 = 0; l1 < 100; l1++)
								{
									chfull[l1] = 0;
								}
								l = 0;
							}
						}
					}


					{

							MessageBox::Show("Ошибка чтения файла!", "Ошибка", MessageBoxButtons::OK, MessageBoxIcon::Warning);


					}

				} */
}
private: System::Void output_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void closePLS_Click(System::Object^  sender, System::EventArgs^  e) {
	
//	fout.close();
	exit(0);
}
private: System::Void addWord_Click(System::Object^  sender, System::EventArgs^  e) {
		
//	fout.open("Dictionary.txt", ofstream::app);
}
private: System::Void searchWord_Click(System::Object^  sender, System::EventArgs^  e) {
}
};
}
