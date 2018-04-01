--[[print("Hello World!")
io.write ("What is your name?\n")
name = io.read()
print ("Hello " .. name)
	if (name == name)
		then print("Go away..." .. name)
	end ]]--
 
 
  function mainMenu()
    print("1. Withdraw\n2. Deposit\n3. Check Account\n4. Exit")
    mainChoice()
  end
  
  function mainChoice()
    mainUserInput = io.read("*n")
      if mainUserInput == 1
        then withdrawFunc()
      elseif mainUserInput == 2
        then depositFunc()
      elseif mainUserInput == 3
        then balanceFunc()
      elseif mainUserInput == 4
        then exitFunc()
      else print("The menu doesn't contain this value! Try again!")
        mainChoice()
      end
  end
  
  function withdrawFunc()
    if balance == -2000 then
      print(name .. ", you are no longer a member of this bank, we've sent you to collection.")
      exitFunc()
    end
    if balance > 1 then
    print("You have $" .. balance .. " in your account right now.\nHow much would you like to take out?")
    withdrawAmount = io.read("*n")
    balance = balance - withdrawAmount
    mainMenu()
      else
      strike = strike + 1
      print("You have no money! You can't withdraw!")
      if strike >= 3
        then balance = balance - 50
          mainMenu()
      else mainMenu()
      end
    end
  end
  
  function depositFunc()
    if balance == -2000 then
      print(name .. ", you are no longer a member of this bank, we've sent you to collection.")
      exitFunc()
    end
    print("You have $" .. balance .. " in your account right now.\nHow much would you like to add?")
    depositAmount = io.read("*n")
    balance = balance + depositAmount
    if balance > 0 then
      strike = 0
    end
    mainMenu()
  end
  
  function balanceFunc()
    print("Your balance is $" .. balance .. "!")
    if balance == -1000 then
      print(name .. ", ADD SOME MONEY INTO YOUR ACCOUNT! DEACTIVATION IS IMMINENT!")
    end
    
    if balance == -2000 then
      print(name .. ", you are no longer a member of this bank, we've sent you to collection.")
      exitFunc()
    end
    mainMenu()
  end
  
  function exitFunc()
    os.exit()
  end
  
  balance = 1000
  strike = 0
  print("Hello, Welcome to Lua Bank Online™, the online ATM where the points... err, money don't matter!")
  print("Would you please enter your name?")
  name = io.read();
  print("Hello, ".. name .. "! What would you like to do?")
  mainMenu()