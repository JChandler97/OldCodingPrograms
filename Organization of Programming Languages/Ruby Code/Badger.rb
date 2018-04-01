class Badger
  
  attr_accessor :name, :size # Creates getter and setter methods.
  
  def initialize(name, size)
    @name = name
    @size = size
  end
  
  # Instance method
  def name_backwards
    @name.reverse
  end
  
  #
  def self.
  
end

# Create the new instance.
badger = Badger.new('Charles', 12)

# Access it's attributes.
puts badger.size # => 12
puts badger.name # => Charles
badger.size = 15
puts badger.size # => 15

puts badger.double_size # => 30

# singleton methods
def badger.moo
  puts "moo"
end
end
end