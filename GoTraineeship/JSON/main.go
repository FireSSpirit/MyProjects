package main

import (
	"database/sql"
	"encoding/json"
	"fmt"
	"os"
	"time"

	_ "github.com/lib/pq"
)

type Json_DB struct {
	Order_uid string
	Jsonb     []byte
}

type Order struct {
	Order_uid    string `json:"order_uid"`
	Track_number string `json:"track_number"`
	Entry        string `json:"entry"`
	Delivery     struct {
		Name    string `json:"name"`
		Phone   string `json:"Phone"`
		Zip     string `json:"zip"`
		City    string `json:"city"`
		Address string `json:"address"`
		Region  string `json:"region"`
		Email   string `json:"email"`
	} `json:"delivery"`
	Payment struct {
		Transaction   string  `json:"transaction"`
		Request_id    string  `json:"request_id"`
		Currency      string  `json:"currency"`
		Provider      string  `json:"provider"`
		Amount        float32 `json:"amount"`
		Payment_dt    uint64  `json:"payment_dt"`
		Bank          string  `json:"bank"`
		Delivery_cost int     `json:"delivery_cost"`
		Goods_total   uint16  `json:"goods_total"`
		Custom_fee    int     `json:"custom_fee"`
	} `json:"payment"`
	Items []struct {
		Chrt_id      int32   `json:"chrt_id"`
		Track_number string  `json:"track_number"`
		Price        float32 `json:"price"`
		Rid          string  `json:"rid"`
		Name         string  `json:"name"`
		Sale         int     `json:"sale"`
		Size         string  `json:"size"`
		Total_price  float32 `json:"total_price"`
		Nm_id        int32   `json:"nm_id"`
		Brand        string  `json:"brand"`
		Status       uint16  `json:"status"`
	} `json:"items"`
	Locale             string    `json:"locale"`
	Internal_signature string    `json:"internal_signature"`
	Customer_id        string    `json:"Customer_id"`
	Delivery_service   string    `json:"delivery_service"`
	Shardkey           string    `json:"shardkey"`
	Sm_id              int       `json:"sm_id"`
	Date_created       time.Time `json:"date_created"`
	Oof_shard          string    `json:"oof_shard"`
}

// "{""entry"": ""WBIL"", ""items"": [{""rid"": ""ab4219087a764ae0btest"", ""name"": ""Mascaras"", ""sale"": 30, ""size"": ""0"", ""brand"": ""Vivienne Sabo"", ""nm_id"": 2389212, ""price"": 453, ""status"": 202, ""chrt_id"": 9934930, ""total_price"": 317, ""track_number"": ""WBILMTESTTRACK""}], ""sm_id"": 99, ""locale"": ""en"", ""payment"": {""bank"": ""alpha"", ""amount"": 1817, ""currency"": ""USD"", ""provider"": ""wbpay"", ""custom_fee"": 0, ""payment_dt"": 1637907727, ""request_id"": """", ""goods_total"": 317, ""transaction"": ""b563feb7b2b84b6test"", ""delivery_cost"": 1500}, ""delivery"": {""zip"": ""2639809"", ""city"": ""Kiryat Mozkin"", ""name"": ""Test Testov"", ""email"": ""test@gmail.com"", ""phone"": ""+9720000000"", ""region"": ""Kraiot"", ""address"": ""Ploshad Mira 15""}, ""shardkey"": ""9"", ""oof_shard"": ""1"", ""order_uid"": ""b563feb7b2b84b6test"", ""customer_id"": ""test"", ""date_created"": ""2021-11-26T06:22:19Z"", ""track_number"": ""WBILMTESTTRACK"", ""delivery_service"": ""meest"", ""internal_signature"": """"}"
// func (o Order) Value() (driver.Value, error) {
// 	return json.Marshal(o)
// }

// func (o *Order) Scan(value interface{}) error {
// 	b, ok := value.([]byte)
// 	if !ok {
// 		return errors.New("type assertion to []byte failed")
// 	}
// 	return json.Unmarshal(b, &o)
// }

func main() {
	// db, err := sql.Open("postgres", "postgres://user:pass@localhost/db")
	// if err != nil {
	// 	log.Fatal(err)
	// }
	// order := new(Order)
	// order.Na

	dataJson, err := os.ReadFile("model.json")
	if err != nil {
		fmt.Println(err)
		return
	}
	var dataOrder Order

	byt := []byte(dataJson)
	if err := json.Unmarshal(byt, &dataOrder); err != nil {
		panic(err)
	}
	fmt.Println(len(dataOrder.Items))

	// fmt.Print("data:  ", string(data))
	// var slice []string
	// err = json.Unmarshal(data, &slice)
	// if err != nil {
	// 	fmt.Println(err)
	// 	return
	// }
	// fmt.Printf("slice: %q\n", slice)
	connStr := "user=Anatoly password=fihl4jp59 dbname=Test_DB sslmode=disable"
	db, err := sql.Open("postgres", connStr)
	if err != nil {
		panic(err)
	}
	defer db.Close()
	// result := getResult(dat.Order_uid, byt, db)
	// fmt.Println(result.LastInsertId()) // не поддерживается
	// fmt.Println(result.RowsAffected()) // количество добавленных строк

	rows, err := db.Query("select * from Json_Test")
	if err != nil {
		panic(err)
	}
	defer rows.Close()

	jsons := []Json_DB{}
	for rows.Next() {
		js := Json_DB{}
		err := rows.Scan(&js.Order_uid, &js.Jsonb)
		if err != nil {
			fmt.Println(err)
			continue
		}
		jsons = append(jsons, js)
	}
	for _, js := range jsons {
		fmt.Println(js.Order_uid, string(js.Jsonb))
	}

}

// Json_Test
func getResult(uid string, jsonb []byte, db *sql.DB) sql.Result {
	result, err := db.Exec("insert into Json_Test values ($1, $2)", uid, jsonb)
	if err != nil {
		panic(err)
	}
	return result
}
