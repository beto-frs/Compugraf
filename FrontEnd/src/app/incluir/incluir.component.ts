import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Usuario } from './usuario';
import {NgForm, FormsModule} from '@angular/forms';
import { CepService } from './cep.service';
import { Request, Response } from './usuario.model';
import { UsuariosService } from './usuarios.service';


@Component({
  selector: 'app-incluir',
  templateUrl: './incluir.component.html',
  styleUrls: ['./incluir.component.css']
})
export class IncluirComponent implements OnInit{

  request: Request = {
    cpf: '',
    nome: '',
    sobrenome: '',
    nacionalidade: '',
    cep: '',
    estado: '',
    cidade: '',
    logradouro: '',
    email: '',
    telefone: ''
  }

  constructor(private http: HttpClient, private cepService:CepService, private usuariosService:UsuariosService) { }


  consultaCep(valor,form){
    this.cepService.buscar(valor).subscribe((dados)=> this.populaForm(dados,form));
  }

  populaForm(dados,form){
    form.setValue({
      cep: dados.cep,
      logradouro:dados.logradouro,
      cidade:dados.localidade,
      estado:dados.uf

    })
  }

  private REST_API_SERVER = "http://localhost:8080/api";

  usuario!: Usuario;
  usuarios = [] as any;




  ngOnInit(): void {
    this.http.get(this.REST_API_SERVER).subscribe((data: any)=>{
      this.usuarios = data;
    });
  }

  Save(){
    this.usuariosService.createUser(this.request).subscribe(res => {


    })
  }

}
