CarregarClientes();
function CarregarClientes(){
    let request = new XMLHttpRequest();
    request.open('GET','https://localhost:44319/api/Cliente',false);
    request.send();
    var clientes = JSON.parse(request.responseText);
    
    var tbody = document.getElementById('tabela');
    tbody.innerHTML ='';
    clientes.forEach(element => {
        var tr = 
        `
        <tr>
        <td>${element.clienteId}</td>
        <td>${element.nome}</td>
        <td>${formatar(element.documento)}</td>
        <td>
        <button type="submit" class="btn btn-warning" data-bs-toggle="modal" data-bs-target="#ModalVisualizar" onclick="VisualizarDadosCliente(${element.clienteId})">Visualizar</button>
        <button type="submit" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#ModalEditar" onclick="CarregarClienteEditar( ${element.clienteId} )">Editar</button>
        <button type="submit" class="btn btn-danger" onclick="ExcluirCliente(${element.clienteId})">Apagar</button>
        </td>
        </tr>
        `;
        tbody.innerHTML += tr;
    });
    
}

function VisualizarDadosCliente(id){
    document.getElementById('ImgAleatorio').src = ImagemAleatoria();
    let request = new XMLHttpRequest();
    request.open('GET',`https://localhost:44319/api/Cliente/${id}`,false);
    request.send();
    var cliente = JSON.parse(request.responseText);
    document.getElementById('VisualizarNome').innerText = cliente.nome;
    document.getElementById('VisualizarId').value ="ID: "+ cliente.clienteId;
    document.getElementById('VisualizarDocumento').value = formatar(cliente.documento);
    
    var ListaEnderecos = document.getElementById('ListaEnderecos');
    ListaEnderecos.innerHTML ='<h6 class="card-title">Endereços:</h6>';
    ListaEnderecos.innerHTML +=`<button type='button' class="btn btn-success" onclick="CampoCadastrarEndereco(${cliente.clienteId})">Adicionar novo endereço</button> <br> <br>`;

    
    cliente.enderecos.forEach(element => {
        var tr = 
        `
        <form class="p-3 mb-2 bg-secondary text-white">
        <label for="" class="form-label">Cep:</label>
        <input class="form-control" id="Cep${element.enderecoId}" value="${element.cep}" disabled>
        <label for="" class="form-label">Rua:</label>
        <input class="form-control" id="Rua${element.enderecoId}" value="${element.rua}" disabled>
        <label for="" class="form-label">Bairro:</label>
        <input class="form-control" id="Bairro${element.enderecoId}" value="${element.bairro}" disabled>
        <label for="" class="form-label">Numero: </label>
        <input class="form-control" id="Numero${element.enderecoId}" value="${element.numero}" disabled>
        <label for="" class="form-label">Municipio: </label>
        <input class="form-control" id="Municipio${element.enderecoId}" value="${element.municipio}" disabled >      
        <label class="form-label">Tipo:</label>
        <select id="Tipo${element.enderecoId}" class="form-control" disabled>
        <option value="${element.tipo}" selected disabled hidden>${TipoEndereco(element.tipo)}</option>
        <option value="0">Cobrança</option>
        <option value="1">Comercial</option>
        <option value="2">Correspondencia</option>
        <option value="3">Entrega</option>
        <option value="4">Residencial</option>
        </select>
        <br>
        <button type='button' id="Liberar${element.enderecoId}" class="btn btn-warning" onclick="LiberarEdicaoEndereco(${element.enderecoId})">Liberar edição</button>
        <button type='button' id="Button${element.enderecoId}" class="btn btn-primary" onclick="EditarEndereco(${element.enderecoId})" disabled>Editar</button>
        <button type='button' id="ApagarEndereco${element.enderecoId}" class="btn btn-danger" onclick="VerificarExisteEndereco(${element.clienteId},${element.enderecoId})">Apagar endereco</button>
        <br><br><p id="Alerta1${element.enderecoId}" class="alert alert-danger" role="alert" hidden>Você não pode deixar um cliente sem um endereço cadastrado! </p>
        </form>
        <br>
        `;
        ListaEnderecos.innerHTML += tr;
    });
    
    
    var ListarTelefones = document.getElementById('ListarTelefones');
    ListarTelefones.innerHTML =`<h6 class="card-title">Telefones:</h6>`;
    ListarTelefones.innerHTML +=`<button type='button' class="btn btn-success" onclick="CampoCadastrarTelefone(${cliente.clienteId})">Adicionar novo Telefone</button> <br><br>`;
    cliente.telefones.forEach(element => {
        var tr2 = 
        `
        <form class="p-3 mb-2 bg-secondary text-white">
        <label class="form-label">Numero:</label>
        <input class="form-control" id="Numero${element.telefoneId}" value="${element.numero}" disabled>
        <label class="form-label">Tipo:</label>
        <select id="TipoTelefone${element.telefoneId}" class="form-control" disabled>
        <option value="${element.tipo}" selected disabled hidden>${TipoTelefone(element.tipo)}</option>
        <option value="0">Celular</option>
        <option value="1">Residencial</option>
        <option value="2">Comercial</option>
        </select>
        <br>
        <button type='button' id="LiberarTelefone${element.telefoneId}" class="btn btn-warning" onclick="LiberarEdicaoTelefone(${element.telefoneId})">Liberar edição</button>
        <button type='button' id="ButtonTelefone${element.telefoneId}" class="btn btn-primary" onclick="EditarTelefone(${element.telefoneId})" disabled>Editar</button>
        <button type='button' id="ApagarTelefone${element.telefoneId}" class="btn btn-danger" onclick="VerificarExisteTelefones(${element.clienteId},${element.telefoneId})">Apagar telefone</button>
        <br><br><p id="Alerta${element.telefoneId}" class="alert alert-danger" role="alert" hidden>Você não pode deixar um cliente sem um endereço cadastrado! </p>
        </form>
        <br>
        `;
        ListarTelefones.innerHTML += tr2;
    });
    
}

function VerificarExisteTelefones(id, telefoneId){
    var alerta = document.getElementById(`Alerta${telefoneId}`);
    let request = new XMLHttpRequest();
    request.open('GET',`https://localhost:44319/api/Telefone/${id}`,false);
    request.send();
    var telefones = JSON.parse(request.responseText);
    if(telefones.length == 1){ 
        alerta.hidden = false;
        alerta.innerHTML ="Você não pode deixar um cliente sem um telefone cadastrado!";
    }else{
        if(confirm("Deseja apagar esse telefone?")){
            alerta.hidden = true;
            ApagarTelefone(telefoneId);
            VisualizarDadosCliente(id);           
        }
    }
}

function VerificarExisteEndereco(id, enderecoid){
    var alerta = document.getElementById(`Alerta1${enderecoid}`);
    let request = new XMLHttpRequest();
    request.open('GET',`https://localhost:44319/api/Endereco/${id}`,false);
    request.send();
    var enderecos = JSON.parse(request.responseText);
    if(enderecos.length == 1){ 
        alerta.hidden = false;
    }else{
        if(confirm("Deseja apagar esse endereço?")){
            alerta.hidden = true;
            ApagarEndereco(enderecoid);
            VisualizarDadosCliente(id);           
        }
    }
}

function ApagarEndereco(id){
    let request = new XMLHttpRequest();
    request.open('DELETE',`https://localhost:44319/api/Endereco/${id}`,false);
    request.send();
}

function ApagarTelefone(id){
    let request = new XMLHttpRequest();
    request.open('DELETE',`https://localhost:44319/api/Telefone/${id}`,false);
    request.send();
}

function CampoCadastrarTelefone(id){
    var ListarTelefones = document.getElementById('ListarTelefones');
    ListarTelefones.innerHTML = "";
    ListarTelefones.innerHTML =`<h6 class="card-title">Telefones:</h6>`;
    var campo = `<br>
    <div class="container">
    <form id="FormCadastroTelefone" class="p-3 mb-2 bg-success text-white">
        <h6 class="card-title">Cadastrar novo numero</h6>
        <label class="form-label">Numero:</label>
        <input class="form-control" id="CadastrarTelefoneNumero" type="number" value="">
        <label class="form-label">Tipo:</label>
        <select id="CadastrarTelefoneTipo" class="form-control">
            <option value="0">Celular</option>
            <option value="1">Residencial</option>
            <option value="2">Comercial</option>
        </select>
        <br><p id="AlertaCamposTelefone" class="alert alert-danger" role="alert" hidden>Preencha todos os campos!</p>
        <br>
        <button type='button' class="btn btn-warning" onclick="VisualizarDadosCliente(${id})">Cancelar</button>
        <button type='button' class="btn btn-primary" onclick="CadastrarTelefone(${id})">Adicionar</button>
    </form>
</div>`;
ListarTelefones.innerHTML += campo;
}

function CadastrarTelefone(id){
    var alerta = document.getElementById(`AlertaCamposTelefone`);
    var numero = document.getElementById(`CadastrarTelefoneNumero`).value;
    var tipo = document.getElementById(`CadastrarTelefoneTipo`).value;
    if(numero ===""||tipo ===undefined){
        alerta.hidden = false;
    }else{
        alerta.hidden = true;
        tipo = parseInt(tipo);
        
        var NovoNumero = {
            clienteId: id,
            numero,
            tipo
        }
        let request = new XMLHttpRequest();
            request.open('POST',`https://localhost:44319/api/Telefone`,false);
            request.setRequestHeader('content-type','application/json');
            request.send(JSON.stringify(NovoNumero));
            VisualizarDadosCliente(id);
    }
}

function CampoCadastrarEndereco(id){
    var ListaEnderecos = document.getElementById('ListaEnderecos');
    ListaEnderecos.innerHTML = "";
    ListaEnderecos.innerHTML =`<h6 class="card-title">Endereços:</h6>`;
    var campo = `<br>
    <div class="container">
    <form id="FormCadastroTelefone" class="p-3 mb-2 bg-success text-white">
        <h6 class="card-title">Cadastrar novo endereço:</h6>
        <label for="" class="form-label">Cep:</label>
        <input class="form-control" id="CadastrarEnderecoCep" value="">
        <label for="" class="form-label">Rua:</label>
        <input class="form-control" id="CadastrarEnderecoRua" value="">
        <label for="" class="form-label">Bairro:</label>
        <input class="form-control" id="CadastrarEnderecoBairro" value="">
        <label for="" class="form-label">Numero: </label>
        <input class="form-control" id="CadastrarEnderecoNumero" value="">
        <label for="" class="form-label">Municipio: </label>
        <input class="form-control" id="CadastrarEnderecoMunicipio" value="" >      
        <label class="form-label">Tipo:</label>
        <select id="CadastrarEnderecoTipo" class="form-control">
        <option value="0">Cobrança</option>
        <option value="1">Comercial</option>
        <option value="2">Correspondencia</option>
        <option value="3">Entrega</option>
        <option value="4">Residencial</option>
        </select>
        <br><p id="AlertaCamposEndereco" class="alert alert-danger" role="alert" hidden>Preencha todos os campos!</p>
        <button type='button' class="btn btn-warning" onclick="VisualizarDadosCliente(${id})">Cancelar</button>
        <button type='button' class="btn btn-primary" onclick="CadastrarEndereco(${id})">Adicionar</button>
    </form>
</div>`;
ListaEnderecos.innerHTML += campo;
}

function CadastrarEndereco(id){
    var alerta = document.getElementById(`AlertaCamposEndereco`);
    var cep = document.getElementById(`CadastrarEnderecoCep`).value;
    var rua = document.getElementById(`CadastrarEnderecoRua`).value;
    var bairro = document.getElementById(`CadastrarEnderecoBairro`).value;
    var numero = document.getElementById(`CadastrarEnderecoNumero`).value;
    var municipio = document.getElementById(`CadastrarEnderecoMunicipio`).value;
    var tipo = document.getElementById(`CadastrarEnderecoTipo`).value;
    if(cep ===""||tipo ===undefined || Number.isInteger(parseInt(numero)) ==false || rua ===""|| bairro ===""||municipio ===""){
        alerta.hidden = false;
    }else{
        alerta.hidden = true;
        tipo = parseInt(tipo);
        numero = parseInt(numero);
        
        var NovoEndereco = {
            cep,
            rua,
            bairro,
            numero,
            municipio,
            tipo,
            clienteId: id
        }
        let request = new XMLHttpRequest();
            request.open('POST',`https://localhost:44319/api/Endereco`,false);
            request.setRequestHeader('content-type','application/json');
            request.send(JSON.stringify(NovoEndereco));
            VisualizarDadosCliente(id);
    }
}

function LiberarEdicaoEndereco(id){
    
    if(document.getElementById(`Cep${id}`).disabled == true){
        document.getElementById(`Liberar${id}`).innerHTML = 'Cancelar Edição';
        document.getElementById(`Cep${id}`).disabled = false;
        document.getElementById(`Rua${id}`).disabled = false;
        document.getElementById(`Bairro${id}`).disabled = false;
        document.getElementById(`Numero${id}`).disabled = false;
        document.getElementById(`Municipio${id}`).disabled = false;
        document.getElementById(`Tipo${id}`).disabled = false;    
        document.getElementById(`Button${id}`).disabled = false;
    }else{
        document.getElementById(`Liberar${id}`).innerHTML = 'Liberar edição';
        document.getElementById(`Cep${id}`).disabled = true;
        document.getElementById(`Rua${id}`).disabled = true;
        document.getElementById(`Bairro${id}`).disabled = true;
        document.getElementById(`Numero${id}`).disabled = true;
        document.getElementById(`Municipio${id}`).disabled = true;
        document.getElementById(`Tipo${id}`).disabled = true;    
        document.getElementById(`Button${id}`).disabled = true;
    }
    
}

function EditarEndereco(id){
    var cep = document.getElementById(`Cep${id}`).value;
    var rua = document.getElementById(`Rua${id}`).value;
    var bairro = document.getElementById(`Bairro${id}`).value;
    var numero = document.getElementById(`Numero${id}`).value;
    var municipio = document.getElementById(`Municipio${id}`).value;
    var tipo = document.getElementById(`Tipo${id}`).value; 
    
    if(cep === undefined || rua === undefined ||bairro === undefined ||
        numero === undefined ||municipio === undefined ||tipo === undefined){
            alert("Preencha todos os campos!");
        }else{
            numero = parseInt(numero);
            tipo = parseInt(tipo);
            
            var enderecoAtualizado =
            {
                cep,
                rua,
                bairro,
                numero,
                municipio,
                tipo
            }
            console.table(enderecoAtualizado);
            let request = new XMLHttpRequest();
            request.open('PUT',`https://localhost:44319/api/Endereco/${id}`,false);
            request.setRequestHeader('content-type','application/json');
            request.send(JSON.stringify(enderecoAtualizado));
            LiberarEdicaoEndereco(id);
        }
}
    
function LiberarEdicaoTelefone(id){
        if(document.getElementById(`Numero${id}`).disabled == true){
            document.getElementById(`LiberarTelefone${id}`).innerHTML = 'Cancelar Edição';
            document.getElementById(`Numero${id}`).disabled = false;
            document.getElementById(`TipoTelefone${id}`).disabled = false;
            document.getElementById(`ButtonTelefone${id}`).disabled = false;
        }else{
            document.getElementById(`LiberarTelefone${id}`).innerHTML = 'Liberar Edição';
            document.getElementById(`Numero${id}`).disabled = true;
            document.getElementById(`TipoTelefone${id}`).disabled = true;
            document.getElementById(`ButtonTelefone${id}`).disabled = true;
        }
        
}
function EditarTelefone(id){
        var numero = document.getElementById(`Numero${id}`).value;
        var tipo = document.getElementById(`TipoTelefone${id}`).value;
        if(numero ===undefined||tipo ===undefined){
            alert("Preencha todos os campos!");
        }else{
            tipo = parseInt(tipo);
            
            var numeroAtualizado = {
                numero,
                tipo
            }
            console.table(numeroAtualizado);
            let request = new XMLHttpRequest();
            request.open('PUT',`https://localhost:44319/api/Telefone/${id}`,false);
            request.setRequestHeader('content-type','application/json');
            request.send(JSON.stringify(numeroAtualizado));
            LiberarEdicaoTelefone(id);
        }
}
    
function Cadastrar(){
        var alerta = document.getElementById('AlertaDocumento');
        var alerta2 = document.getElementById('AlertaCadastrar');
        var alerta3 = document.getElementById('AlertaErro');
        var _nome = document.getElementById('Nome').value;
        var _documento = document.getElementById('Documento').value;
        var _cep = document.getElementById('Cep').value;
        var _rua = document.getElementById('Rua').value;
        var _bairro = document.getElementById('Bairro').value;
        var _numeroCasa = document.getElementById('NumeroCasa').value;
        var _municipio = document.getElementById('Municipio').value;
        var _enderecoTipo = document.getElementById('EnderecoTipo').value;
        var _numeroTelefone = document.getElementById('NumeroTelefone').value;
        var _telefoneTipo = document.getElementById('TelefoneTipo').value;
              
        if(
            _nome === "" ||_documento=== "" ||
            _cep=== "" || _rua=== "" ||
            _bairro=== "" || _municipio=== "" ||
            _numeroTelefone=== ""||Number.isInteger(parseInt(_numeroCasa)) ==false){
                alerta2.hidden = false;
                return false;
            }else if(_documento.length != 11 && _documento.length != 15){
                alerta2.hidden = true;
                alerta.hidden = false;
                alerta3.hidden = false;
                return false;
            }
            alerta2.hidden = true;

            alerta.hidden = true;
            alerta3.hidden = true;
            var cliente = {
                nome: _nome,
                documento: _documento,
                cep: _cep,
                rua: _rua,
                bairro: _bairro,
                numeroCasa: parseInt(_numeroCasa),
                municipio: _municipio,
                enderecoTipo: parseInt(_enderecoTipo),
                numeroTelefone: _numeroTelefone,
                telefoneTipo: parseInt(_telefoneTipo)
            }
            console.table(cliente);  
            let request = new XMLHttpRequest();
            request.open('POST','https://localhost:44319/api/Cliente',false);
            request.setRequestHeader('content-type','application/json');
            request.send(JSON.stringify(cliente));
            CarregarClientes();
            LimparCamposCadastro();
            $('#ModalCadastrar').modal('hide');
            
            
}
        
function CarregarClienteEditar(id){
            let request = new XMLHttpRequest();
            request.open('GET',`https://localhost:44319/api/Cliente/${id}`,false);
            request.send();
            var cliente = JSON.parse(request.responseText);
            document.getElementById('ClientIdEditar').value = cliente.clienteId;
            document.getElementById('NomeEditar').value = cliente.nome;
            document.getElementById('DocumentoEditar').value = cliente.documento;
            return cliente;
}
        
function EditarCliente(){
            var alerta = document.getElementById('AlertaEditar');
            var alerta2 = document.getElementById('AlertaTamanho');
            var IdCliente = document.getElementById('ClientIdEditar').value;
            var novoNome = document.getElementById('NomeEditar').value;
            var novoDocumento = document.getElementById('DocumentoEditar').value;
            if(novoNome ==="" || novoDocumento ===""){
                alerta.hidden = false;
            }else if(novoDocumento.length != 11 && novoDocumento != 15){
                alerta2.hidden = false;
                console.log("AQUI");
            }
            else{
                alerta.hidden = true;
                alerta2.hidden = true;

                var clienteAtualizado = {
                    nome: novoNome,
                    documento: novoDocumento
                }                
                let request = new XMLHttpRequest();
                request.open('PUT',`https://localhost:44319/api/Cliente/${IdCliente}`,false);
                request.setRequestHeader('content-type','application/json');
                request.send(JSON.stringify(clienteAtualizado));
                LimparCamposEditar();
                CarregarClientes();
                $('#ModalEditar').modal('hide');
            }
}
        
function ExcluirCliente(id){
            if(confirm("Deseja excluir o cliente e todos os seus registros?")){
                let request = new XMLHttpRequest();
                request.open('DELETE',`https://localhost:44319/api/Cliente/${id}`,false);
                request.send();
                LimparCamposEditar();
                CarregarClientes();
            }          
}
        
function LimparCamposCadastro(){
            document.getElementById('Nome').value = '';
            document.getElementById('Documento').value = '';
            document.getElementById('Cep').value = '';
            document.getElementById('Rua').value = '';
            document.getElementById('Bairro').value = '';
            document.getElementById('NumeroCasa').value = '';
            document.getElementById('Municipio').value = '';
            document.getElementById('EnderecoTipo').value = 0;
            document.getElementById('NumeroTelefone').value = '';
            document.getElementById('TelefoneTipo').value = 0;
}
        
function LimparCamposEditar(){
            document.getElementById('ClientIdEditar').value = '';
            document.getElementById('NomeEditar').value = '';
            document.getElementById('DocumentoEditar').value = '';
}
        
function formatar(documento){
            if(documento.length == 11){
                documento = documento.replace(/[^\d]/g, "");
                return documento.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, "$1.$2.$3-$4");
            } 
            if(documento.length == 15){
                return documento.replace(/^(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})/, "$1.$2.$3/$4-$5");
            }else{
                return "Documento errado!"
            }
            
}
        
function TipoEndereco(tipo){
            if(tipo === 0){
                return "Cobrança"
            }if(tipo === 1){
                return "Comercial"
            }if(tipo === 2){
                return "Correspondencia"
            }if(tipo === 3){
                return "Entrega"
            }if(tipo === 4){
                return "Residencial"
            }
            
            if(tipo ==="Cobrança"){
                return 0;
            }if(tipo ==="Comercial"){
                return 1;
            }if(tipo ==="Correspondencia"){
                return 2;
            }if(tipo ==="Entrega"){
                return 3;
            }if(tipo ==="Residencial"){
                return 4;
            }
}
              
function TipoTelefone(tipo){
            if(tipo === 0){
                return "Celular"
            }if(tipo === 1){
                return "Residencial"
            }if(tipo === 2){
                return "Comercial"
            }
            
            if(tipo === "Celular"){
                return 0;
            }if(tipo === "Residencial"){
                return 1;
            }if(tipo ==="Comercial"){
                return 2;
            }
}

function ImagemAleatoria(){
    var resultado = Math.floor(Math.random() * 10);
    var img;
    switch(resultado) {
        case 0:
            img = "https://st3.depositphotos.com/9881890/13396/i/600/depositphotos_133960224-stock-photo-smiling-young-man.jpg";
          break;
        case 1:
            img = "https://www.revistaplaneta.com.br/wp-content/uploads/sites/3/2017/05/15_pl530_pessoa.jpg";
          break;
          case 2:
            img = "https://www.capila.com.br/wp-content/uploads/2019/12/quantos-fios-de-cabelo-tem-uma-pessoa-com-25-anos-29122019.jpg";
          break;
          case 3:
            img = "https://ferramentasdecoaching.net/wp-content/uploads/2018/07/muitomaisdoqueumametodologia.jpg";
          break;
          case 4:
            img = "https://img.freepik.com/fotos-gratis/mulher-triste-pensando_23-2147813584.jpg?size=626&ext=jpg";
          break;
          case 5:
            img = "https://img.freepik.com/fotos-gratis/menina-linda-com-seu-penteado_23-2147639438.jpg?size=626&ext=jpg"
          break;
          case 6:
            img = "https://static.cobrefacil.com.br/assets/base/035/3ab/4cb/gerar-boleto-gratis-pessoa-fisica.jpg";
          break;
          case 7:
            img = "https://www.comparaonline.com.br/blog-statics/br/uploads/2014/01/pagar-contas-com-cartao-credito.jpg";
          break;
          case 8:
            img = "https://www.itau.com.br/content/dam/itau/cartoes/servi%C3%A7os/pague-contas.jpeg";
          break;
          case 9:
            img = "https://www.itau.com.br/content/dam/itau/varejo/seguros/prestamista/parcelamento/banner-parcelamento.jpg";
          break;
      }
      return img;

}