import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  // public evento: any =  {
  //   Tema : 'Angular',
  //   Local : 'Aracaju'}
  //   //evento, do tipo any, atribuido à ele um objeto

  // public eventos: any =[
    // {
    //     Tema : 'Angular',
    //     Local : 'Sao Paulo'},
    //     {
    //       Tema : 'C#',
    //       Local : 'Brasilia'},
    //       {
    //         Tema : 'Python',
    //         Local : 'Aracaju'}
  // ]
// //testando o ng-for
public eventos : any;

  constructor(private varhttp:HttpClient) { }

  ngOnInit() : void {
    // o método criado so vai funcionar se for chamado aqui dentro
    this.getEventos ();
  }

  // public getEventos () : void {
  //   //CLASSE no typescript o this é obrigatório dentro de classes
  //   this.eventos = [
  //        {
  //         Tema : 'Angular',
  //         Local : 'Sao Paulo'},
  //         {
  //         Tema : 'C#',
  //         Local : 'Brasilia'},
  //         {
  //           Tema : 'Python',
  //           Local : 'Aracaju'}]}
  // Agora, para vir do banco de dados, da API, preciso ir fazer referencia no app.module.ts !!!

  public getEventos () : void {
    this.varhttp.get('https://localhost:5001/api/Eventos').subscribe(
      response => this.eventos = response,
      //tipo um callback
      error => console.log(error)
    );
  };
}
