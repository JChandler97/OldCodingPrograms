! This program shows examples of the Fortran control structures.
! Author: Jacob Hapner

	PROGRAM ControlStructures
	integer :: counter = 1
	if (1 .LT. 2) then
		print *, '1 < 2'
	else if (1 .GT. 2) then
		print *, '1 > 2'
	else
		print *, '1 = 2'
	end if
	do i = 1, 3
		print *, i
	end do
	do
		counter = counter + 1
		if (counter > 10) exit
	end do
	print *, counter
!	DO
!		IF (i < 5) THEN
!			i = i + 1
!		ELSE
!			EXIT
!		END IF
!	END DO
!	PRINT *, i
	END PROGRAM ControlStructures
