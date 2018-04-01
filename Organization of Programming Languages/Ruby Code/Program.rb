class Program
	
	@@arrayOne = Array.new
	@@arrayTwo = Array.new
	@@arrayThree = Array.new
	
	def getGem
		puts "What is your gem? If you are done, press enter."
		$name = gets.chomp.capitalize
		if $name != ''
		@@arrayOne << $name
		end
	end
	
	def getColor
		puts "What is the color of your gem?"
		$color = gets.chomp.capitalize
		@@arrayTwo << $color
	end	
	
	def getPrice
		puts "What is the price of your gem?"
		$price = gets.chomp.to_i
		@@arrayThree << $price
	end	
	
	def displayArray
		puts @@arrayOne
		puts @@arrayTwo
		puts @@arrayThree
	end
	
	
end


	program = Program.new
	until ($name == '')
	program.getGem
	program.getColor
	program.getPrice
	program.displayArray
end