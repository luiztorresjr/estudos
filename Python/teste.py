<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ page import="br.edu.infnet.appbiblioteca.model.domain.Obra" %>
<script type="text/javascript">
var autores = new Array();
var genero = new Array();

function setAutor(){
	autor = document.getElementById("autor")
	const x = document.createElement("li");	
	const t = document.createTextNode(autor.value);
	x.appendChild(t);
	x.classList.add("list-group-item");
	document.getElementById("autores").appendChild(x);
	document.getElementById("autor").value=''
}

function setGenero(){
	genero = document.getElementById("gen")
	const x = document.createElement("li");	
	const t = document.createTextNode(genero.value);
	x.appendChild(t);
	x.classList.add("list-group-item");
	document.getElementById("genero").appendChild(x);
	document.getElementById("gen").value=''
}


</script> 
	    <div class="form-group">
	      <label>Registro:</label>
	      <input type="text" class="form-control" placeholder="Entre com o registro"  name="registro">
	    </div>
	    
	    <div class="form-group">
	      <label>Titulo:</label>
	      <input type="text" class="form-control" placeholder="Entre com o titulo" name="titulo">
	    </div>	    

	    <div class="form-group">
	      <label>Numero de pagina:</label>
	      <input type="number" min="0" step="1" class="form-control" placeholder="Entre com o numero de paginas"  name="numeroDePaginas">
	    </div>
	    
		 <div class="form-group">
			 <label>Idioma:</label>
			 <input type="text" class="form-control" placeholder="Entre com o idioma"  name="idioma">
		</div>
			    
	    <div class="form-group">
	    <label>Genero:</label>
			  <input type="text" class="form-control" placeholder="Adicione o genero" name="gen" id="gen">
			  <div class="input-group-append">
			    <button class="btn btn-primary" type="button" onclick="setGenero()">Adicionar</button>
  			</div>	
		</div>	
			<label>Generos:</label>
			<div class="list-group" id="genero" name="genero">			
			  		
			</div>	
			<div class="input-group mb-3">
			<label>Autor:</label>
			  <input type="text" class="form-control" placeholder="Adicione o nome do autor" name="autor" id="autor">
			  <div class="input-group-append">
			    <button class="btn btn-primary" type="button" onclick="setAutor()">Adicionar</button>
  			</div>
  			
			</div>	
			<label>Autores:</label>
			<div class="list-group" id="autores" name="autores">			
			  		
			</div>	
		
	