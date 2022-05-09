import { https } from './config'

export default	{
	listar:()=>{return https.get('cliente') },
	salvar:(cliente)=>{return https.post('cliente', cliente); },
	atualizar:(cliente)=>{return https.put('cliente',cliente); },
	buscar:(id)=>{return https.get(`cliente/id?id=${id}`)},
	apagar:(id)=>{return https.delete(`cliente/id?id=${id}`)},
	loggerError:(error)=>{return https.post(`error`,error)},
}