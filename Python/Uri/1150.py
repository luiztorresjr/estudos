def read_integer():
  try:
    # read for Python 2.x
    return int(raw_input())
  except NameError:
    # read for Python 3.x
    return int(input())


x = read_integer()
z = read_integer()
while(z <= x):
  z = read_integer()

soma = x
contar = 0

while(soma <= z):
    soma += (x + 1) 
    contar += 1
    
print(contar)
