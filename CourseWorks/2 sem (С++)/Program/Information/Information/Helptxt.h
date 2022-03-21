#pragma once
#include <string>
#include <fstream>
class Helptxt {
public:
	std::string gimme;
	char slesh = '/';
	char down = '\n';
	void Clear()
	{
		remove("InformationsAboutAuthors.txt");
	}
};

