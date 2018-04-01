=begin
words = []
say = 'nil'

while say != ''
  puts 'say a word: '
  talk = gets.chomp
  exit false if talk.empty?
  words.flatten talk.to_s
  end
  puts words
  puts words.sort 
=end
=begin
array = Array.new
n = 0
say = 'nil'
while say == ''
gemName = gets.chomp
color = gets.chomp
price = gets.chomp.to_i

array = [[gemName, color, price]]
puts array[n]
n= n+1
end
=end

x = Array.new
puts "enter something:".capitalize
y = ''
while y !=#nill
  y = gets.chomp
  x.push y
end
x.delete ('')
x.compact
puts "You entered: " + x.sort.to_s
puts "Objects in array: " + x.size.to_s