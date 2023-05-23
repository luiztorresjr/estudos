if __name__ == '__main__':
    x = int(input())
    y = int(input())
    z = int(input())
    n = int(input())

    lista = []
    elemento = []
    for a in range(x):
        for b in range(y):
            for c in range(z):
                elemento.append(a, b, c)
    print(elemento)
    