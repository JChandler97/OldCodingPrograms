	PROGRAM FibonacciCalc
	
	double precision :: First, Second, Temp
	integer :: Counter, TempFinder, UserInput
	WRITE(*,*) 'Input an integer to determine Fib digit'
	READ(*,*) UserInput

	First = 0
	Second = 1
	IF (UserInput .EQ. 1) THEN
		WRITE(*,*) First

	ELSE IF (UserInput .NE. TempFinder) THEN
		DO Counter = 1, 9000, 1
		Temp = First + Second
		First = Second
		Second = Temp
		TempFinder = log10(abs(Temp)) + 1
	
	IF (TempFinder .EQ. UserInput) EXIT
	 
		END DO
	
		WRITE(*,*) Temp
		
	END IF
	END