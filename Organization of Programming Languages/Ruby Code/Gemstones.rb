class Gemstones
	
	@@arrayOne = Array.new
	@@arrayTwo = Array.new
	@@arrayThree = Array.new
	@@multiArray = Array.new
	
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
	
	def arrayMerge
		@@arrayMerge = @@arrayOne.zip(@@arrayTwo, @@arrayThree)
#		puts @@arrayMerge.inspect
	end	
	
	def sortArray
		puts @@arrayMerge.sort.inspect
	end
	
	def printArray

	end
end


	gemstone = Gemstones.new
	gemstone.getGem
	while $name != ""	
	gemstone.getColor
	gemstone.getPrice
	gemstone.getGem
	end
	
	gemstone.arrayMerge
	puts "Gem\tColor\tPrice"
	gemstone.sortArray