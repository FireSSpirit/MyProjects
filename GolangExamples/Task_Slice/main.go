package main

// Функция, которая возвращает пересечение слайсов
import "fmt"

func main() {
	messages1 := []int{6, 2, 9, 10, 0}

	messages2 := []int{1, -7, 6, 0, 8}

	fmt.Println(check1(messages1, messages2))
	fmt.Println(check2(messages1, messages2))
}

//O(n*n)
func check1(mes1, mes2 []int) []int {

	mesResult := make([]int, 0)
	for i := range mes1 {
		for j := range mes2 {
			if mes1[i] == mes2[j] {
				mesResult = append(mesResult, mes1[i])
				break
			}
		}
	}
	return mesResult
}

func check2(mes1, mes2 []int) []int {
	counter := make(map[int]int)
	var result []int

	for _, elem := range mes1 {
		if _, ok := counter[elem]; !ok {
			counter[elem] = 1
		} else {
			counter[elem] += 1
		}
	}
	for _, elem := range mes2 {
		if count, ok := counter[elem]; ok && count > 0 {
			counter[elem] -= 1
			result = append(result, elem)
		}
	}
	return result
}
