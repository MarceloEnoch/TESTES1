import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  // se eu comentar esse tempalteUrl e colocar template normal, o html teria que ser carregado na mão
  templateUrl: './app.component.html',
  //asim:
  //template : '<h1> Olá mundo </h1>',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Primeiro-APP';
}
