
import pyodbc 
import xml.etree.ElementTree as ET

tree = ET.parse('NF.xml')
root = tree.getroot()

ns = '{http://www.portalfiscal.inf.br/nfe}'

nf ='{}cProd'.format(ns)
codprod = []
for movie in root.iter(nf):
    codprod.append(float(movie.text))

nf = '{}qCom'.format(ns)
quantidade = []
for movie in root.iter(nf):
    quantidade.append(float(movie.text))

valor=[]
nf = '{}vUnCom'.format(ns)
for movie in root.iter(nf):
    valor.append(float(movie.text))
    
    
    
# Some other example server values are
# server = 'localhost\sqlexpress' # for a named instance
# server = 'myserver,port' # to specify an alternate port
server = '' 
database = '' 
username = '' 
password = '' 
cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = cnxn.cursor()

for i in range(len(codprod)):
    count = cursor.execute("""
    INSERT INTO Produtos (codigo do produto, quantidade, valor) 
    VALUES (?,?,?)""",
    codprod[i], quantidade[i], valor[i]).rowcount
    cnxn.commit()
    print('Rows inserted: ' + str(count))
    