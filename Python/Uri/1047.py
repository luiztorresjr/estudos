
lista = None

def read_line():
  try:
    # read for Python 2.x
    return raw_input()
  except NameError:
    # read for Python 3.x
    return input()

lista = read_line().split(" ")
hora = []
minuto = []
hora.append(int(lista[0]))
hora.append(int(lista[2]))
minuto.append(int(lista[1]))
minuto.append(int(lista[3]))

if(minuto[1] >= minuto[0]):
  minuto_duracao = minuto[1] - minuto[0]
  if(hora[0] == hora[1] and minuto[1]> minuto[0]):
    hora_duracao = 0
  elif(hora[0] == hora[1] and minuto[1] == minuto[0]):
    hora_duracao = 24
  elif(hora[1]> hora[0]):
    hora_duracao = hora[1]-hora[0]
  else:
    hora_duracao = (hora[1]-hora[0])+24
else:
  minuto_duracao = (minuto[1] - minuto[0]) + 60
  hora_duracao = -1
  if(hora[1] >=hora[0]+1):
    hora_duracao += hora[1]-(hora[0])
  else:
    hora_duracao += (hora[1]-hora[0]) +24
  


print(f"O JOGO DUROU {hora_duracao} HORA(S) E {minuto_duracao} MINUTO(S)")

