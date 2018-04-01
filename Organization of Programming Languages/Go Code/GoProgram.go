package main

import (
	"bufio"
	"fmt"
	"regexp"
	"os"
)

func main() {
	
	reader := bufio.NewReader(os.Stdin)
    fmt.Print("Input a variable name: ")
    varName, _ := reader.ReadString('\n')
	
	var varCheck = regexp.MustCompile(`([_A-Za-z^\D]\S)`).MatchString
	
	if(varCheck(varName)){
		fmt.Println("Your variable name is in good standing!")
	} else {
		fmt.Println("Consider changing the name again.")
	}
	
}