package main

// билет на самолет из России в Турцию
import (
	"fmt"
	"math/rand"
)

func main() {
	var distance float32 = 4985 //км
	company := ""
	trip := ""

	fmt.Println("Авиакомпания        Часы на дорогу Пересадка  Цена")
	fmt.Println("==================================================")

	for count := 0; count < 10; count++ {
		switch rand.Intn(3) {
		case 0:
			company = "Победа"
		case 1:
			company = "Аэрофлот"
		case 2:
			company = "Уральские"
		}
		var speed int = 320 + rand.Intn(40)                              // 320-360 км/ч
		var hours float32 = distance / float32(speed)                    // часы
		var price float32 = (200000 + float32(rand.Intn(10000))) / hours // ₽

		if rand.Intn(2) == 1 {
			trip = "Туда и обратно"
			price = price * 2
		} else {
			trip = "В одну сторону"
		}

		fmt.Printf("%-16v %-4v %-10v %-4v ₽\n", company, int(hours), trip, int(price))
	}
}
