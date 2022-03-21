#pragma once
#include <string>
class Author 
{
public:
	char s;
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
class Country : public Author
{
};

