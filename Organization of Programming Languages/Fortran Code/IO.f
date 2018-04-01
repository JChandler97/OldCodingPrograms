! This program shows different ways of using input and output.
! Author: Jacob Hapner

	PROGRAM IO
	integer :: i
	real :: r
	print *, 'Enter an integer followed by a real number.'
	read *, i, r
	print '(/, I4, 2X, F6.2)', i, r
	print '(I2, 2X, E8.2)', i, r
	END PROGRAM IO
