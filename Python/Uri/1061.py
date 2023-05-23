def read_integer():
    try:
        return(int(raw_input()))
    except NameError:
        return int(input())

def read_line():
    try:
        return raw_input()
    except NameError:
        return input()

w=[]
x=[]
y=[]
z=[]
for i in range(2):
    w.append(int(input("Dia ")))
    hora = read_line().split(" : ")
    x.append(int(hora[0]))
    y.append(int(hora[1]))
    z.append(int(hora[2]))
dia = w[1]-w[0]

hora = x[1]-x[0]
if(hora < 0):
    hora += 24
    dia -= 1
minuto = y[1] - y[0]
if(minuto<0):
    hora -=1
    minuto +=60
segundo = z[1]-z[0]
if(segundo <0):
    minuto -= 1
    segundo +=60

print(f"{dia} dia (s)\n{hora} hora (s)\n{minuto} minuto (s)\n{segundo} segundo (s)")


