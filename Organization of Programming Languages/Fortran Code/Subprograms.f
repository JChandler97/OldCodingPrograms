! This program uses different types of subprograms to achieve the same result.
! Author: Jacob Hapner

! This function adds one to the input and returns it.
	integer function PlusOne(OriginalNumber)
	integer :: OriginalNumber
	PlusOne = OriginalNumber + 1
	return
	end
	
! This subroutine adds one to the input and stores it.
	subroutine PlusOneSub(OriginalNumber)
	integer :: OriginalNumber
	OriginalNumber = OriginalNumber + 1
	return
	end
	
	PROGRAM Subprograms
	integer :: MyNumber, PlusOne
	MyNumber = 3
	print *, MyNumber
	MyNumber = PlusOne(MyNumber)
	print *, MyNumber
	call PlusOneSub(MyNumber)
	print *, MyNumber
! This program shows that functions and subroutines can do the same thing.
	END PROGRAM Subprograms
