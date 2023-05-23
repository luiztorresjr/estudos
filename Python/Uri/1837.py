
def read_line():
  try:
    # read for Python 2.x
    return raw_input()
  except NameError:
    # read for Python 3.x
    return input()


linha =  read_line().split(" ")
numero = []
for i in linha:
    numero.append(int(i))

b = numero[1]
a = numero[0]

if(b < 0):
    modulo_b = b * -1
else:
    modulo_b = b

print(f'{int((a-(a%modulo_b))/b)} {a%modulo_b}')




