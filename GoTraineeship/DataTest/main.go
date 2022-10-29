package main

import (
	"database/sql"
	"fmt"

	_ "github.com/lib/pq"
)

type product struct {
	id      int
	company string
	model   string
	price   int
}

func main() {
	connStr := "user=Anatoly password=fihl4jp59 dbname=Test_DB sslmode=disable"
	db, err := sql.Open("postgres", connStr)
	if err != nil {
		panic(err)
	}
	defer db.Close()
	// result := getResult(db)
	// fmt.Println(result.LastInsertId()) // не поддерживается
	// fmt.Println(result.RowsAffected()) // количество добавленных строк

	// var id int
	// db.QueryRow("insert into Products (model, company, price) values ('Mate 10 Pro', $1, $2) returning id",
	// 	"Huawei", 35000).Scan(&id)
	// fmt.Println(id)

	rows, err := db.Query("select * from Products")
	if err != nil {
		panic(err)
	}
	defer rows.Close()

	products := []product{}
	for rows.Next() {
		p := product{}
		err := rows.Scan(&p.id, &p.model, &p.company, &p.price)
		if err != nil {
			fmt.Println(err)
			continue
		}
		products = append(products, p)
	}
	for _, p := range products {
		fmt.Println(p.id, p.model, p.company, p.price)
	}
}

func getResult(db *sql.DB) sql.Result {
	result, err := db.Exec("insert into Products (model, company, price) values ('iPhone X', $1, $2)",
		"Apple", 72000)
	if err != nil {
		panic(err)
	}
	return result
}
