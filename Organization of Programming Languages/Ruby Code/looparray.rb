array = Array.new
puts 'Hi, do you need something sorted?'
yn = gets.chomp
while yn != 'no'
  puts 'What would you like to add'
  array << [gets.chomp]
  puts "array is #{array.inspect}"
  puts "yn is #{yn.inspect}"
  puts 'Add another? yes/no'
  yn = gets.chomp
end