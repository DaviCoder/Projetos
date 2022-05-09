<template>
  <div id="app">

    <nav>
      <div class="nav-wrapper blue darken-1">
        <a href="#" class="brand-logo center">Front consumindo Web API</a>
      </div>
    </nav>

    <div class="container">

      <form @submit.prevent="salvar">

          <label>Nome</label>
          <input type="text" placeholder="Nome" v-model="Cliente.nome" >
          <label>Porte Empresa</label>
          <input type="number" placeholder="Porte empresa" v-model="Cliente.porteEmpresa" >

          <button class="waves-effect waves-light btn-small">Salvar<i class="material-icons left">save</i></button>

      </form>

      <table>

        <thead>

          <tr>
            <th>ID</th>
            <th>NOME</th>
            <th>PORTE EMPRESA</th>
            <th>DATA CRIAÇÃO</th>
          </tr>

        </thead>

        <tbody>

          <tr v-for="Cliente of Clientes" :key="Cliente.id">
            <td>{{ Cliente.id }}</td>
            <td>{{ Cliente.nome }}</td>
            <td>{{ tipoEmpresa(Cliente.porteEmpresa) }}</td>
            <td>{{ Cliente.createdAt }}</td>
            <td>
              <button @click="editar(Cliente)" class="waves-effect btn-small blue darken-1"><i class="material-icons">create</i></button>
              <button @click="remover(Cliente)" class="waves-effect btn-small red darken-1"><i class="material-icons">delete_sweep</i></button>
            </td>

          </tr>

        </tbody>
      
      </table>

    </div>

  </div>
</template>

<script>

import Cliente from './services/cliente'

export default {
  name: 'app',
  data () {
    return {
      Cliente:{
        id: '',
        nome: '',
        porteEmpresa: '',
        createdAt: ''
      },
      Clientes: []
    }
  },

  mounted(){
    this.listar()
  },

  methods:{
    tipoEmpresa(porteEmpresa){
      if(porteEmpresa == 0){
        return 'Pequena'
      }else if(porteEmpresa == 1){
        return 'Média'
      }else if(porteEmpresa == 2){
        return 'Grande'
      }
      },
    listar(){
      Cliente.listar().then(resposta => {
        this.Clientes = resposta.data
      }).catch(e => {
        Cliente.loggerError({Message:'Erro ao listar! '+e.response.data.title})   
      })
    },

    async salvar(){
      if(!this.Cliente.id){
      Cliente.salvar({nome: this.Cliente.nome, porteEmpresa: parseInt(this.Cliente.porteEmpresa)}).then(resposta => {
          this.Cliente = {}
          alert('Cadastrado com sucesso!')
          this.listar()
        }).catch(e => {
          Cliente.loggerError({Message:'Erro ao salvar! '+e.response.data.title})       
        })

      }else{

        Cliente.atualizar({id: parseInt(this.Cliente.id), nome: this.Cliente.nome, porteEmpresa: parseInt(this.Cliente.porteEmpresa)}).then(resposta => {
          this.Cliente = {}
          alert('Atualizado com sucesso!')
          this.listar()
        }).catch(e => {
          Cliente.loggerError({Message:'Erro ao atualizar! '+e.response.data.title})   
        })
      }
    },

    editar(Cliente){
      this.Cliente = Cliente
    },

    async remover(ClienteRes){
      if(confirm('Deseja excluir o Cliente?')){
       await Cliente.apagar(parseInt(ClienteRes.id)).then(resposta => {
          this.listar()
        }).catch(e => {
          Cliente.loggerError({Message:'Erro ao remover! '+e.response.data.title})   
        })
      }

    }
  }

}
</script>

<style>



</style>
