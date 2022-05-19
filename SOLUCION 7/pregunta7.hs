main = do
	print "introducto primer digito"
	a <- getLine
	print "introduca segundo numero "
	b <- getLine
	let x = (read a :: Int)
	let y = (read b :: Int)
	putStrLn "la suma es:"
	print (x + y)
	putStrLn "la resta es:"
	print (x - y)
	putStrLn "la multiplicacion es:"
	print (x * y)
	putStrLn "la divicion es:"
	print (div x y)
	
	