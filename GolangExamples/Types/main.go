package main

import (
	"fmt"
	"os"
)

func main() {
	var yesNo string
	fmt.Fscan(os.Stdin, &yesNo)

	var launch bool

	switch yesNo {
	case "true", "yes", "1":
		launch = true
	case "false", "no", "0":
		launch = false
	default:
		fmt.Println(yesNo, "is not valid")
	}

	fmt.Println("Ready for launch:", launch) // Выводит: Ready for launch: true
}
