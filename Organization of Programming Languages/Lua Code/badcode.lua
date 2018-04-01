print('This is an example of bad code') -- This prints first
a = 5
x = { firstValue = 1, secondValue = 2 }
function foo() local y=x print(x.firstValue) io.write(y.secondValue) end
b ="Hello"
function coolBrains()
 io.write("la dee da dee\n")
 foo() -- Prints fourth
end
print(a) -- Prints second
print(coolBrains()) -- Prints third
print(b) -- Prints last
