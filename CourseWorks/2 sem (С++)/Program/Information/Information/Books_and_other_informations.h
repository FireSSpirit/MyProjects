#pragma once
#include <string>
class Books
{
	public:
	std::string name;
	void be()
	{
	}
};
class Style : public Books
{
public:
	bool Correct(std::string s)
	{
		bool t = true;
		for (int i = 0; i < s.length(); i++)
			if (int(s[i]) > 47 && int(s[i]) < 59)//48-58 это ASCII-коды цифр
			{
				t = false;
				break;
			}
		return t;
	}
};
class Language
{
	public:
	std::string name;
	bool Correct(std::string s)
	{
		bool t = true;
		for (int i = 0; i < s.length(); i++)
			if (int(s[i]) > 47 && int(s[i]) < 59)//48-58 это ASCII-коды цифр
			{
				t = false;
				break;
			}
		return t;
	}
};
class Edition : public Books
{
public:
	bool Correct(std::string s)
	{
		bool t = true;
		for (int i = 0; i < s.length(); i++)
			if (int(s[i]) < 48 || int(s[i]) > 58)//48-58 это ASCII-коды цифр
			{
				t = false;
				break;
			}
		return t;
	}
};
class Publishing
{
public:
	std::string name;
	bool Correct(std::string s)
	{
		bool t = true;
		for (int i = 0; i < s.length(); i++)
			if (int(s[i]) > 47 && int(s[i]) < 59)//48-58 это ASCII-коды цифр
			{
				t = false;
				break;
			}
		return t;
	}
};
