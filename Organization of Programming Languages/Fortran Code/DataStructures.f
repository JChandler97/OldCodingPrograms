! This program shows examples of various Fortran data structures.
! Author: Jacob Hapner

	PROGRAM DataStructures
		integer :: i, Array(3,3)
		real :: a
		double precision :: d
		complex :: q
		logical :: b
		character :: c
		i = 3
		a = 2.5
		d = i*a
		b = d == a
		c = 'Q'
		q = csqrt((-1, 0))
		Array(1,1) = 1
		Array(3,3) = 9
		print *, 'i = ', i
		print *, 'real(i) = ', real(i)
		print *, 'dble(i) = ', dble(i)
		print *, 'a = ', a
		print *, 'int(a) = ', int(a)
		print *, 'b = ', b
		print *, 'c = ', c
		print *, 'd = ', d
		print *, 'q = ', q
		print *, 'Array(1,1) = ', Array(1,1)
		print *, 'Array(3,3) = ', Array(3,3)
		print *, 'char(42) = ', char(42)
		print *, 'ichar(''*'') = ', ichar('*')
!		print *, 2+1-10/3/4
	END PROGRAM DataStructures
