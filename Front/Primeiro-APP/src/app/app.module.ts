import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule }  from '@angular/common/http';
import { BrowserAnimationsModule }  from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';

@NgModule({
  declarations: [
      AppComponent,
      EventosComponent,
      PalestrantesComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    // add na mão para nos proporcionar a possibilidade de usar dentro do compuonente o Http Client.
    BrowserAnimationsModule
    //ngx-bootstrap passou a precisar desse browseranimationsmodule...
  ],
  providers: [],
  bootstrap: [AppComponent]
  // inicializar a plicação com esse appcomponent, por isso app.component é  usado como o 'style'
})
export class AppModule { }
