import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ListarComponent } from './listar/listar.component';
import { ApagarComponent } from './apagar/apagar.component';
import { IncluirComponent } from './incluir/incluir.component';
import { AlterarComponent } from './alterar/alterar.component';
import { HeaderComponent } from './header/header.component';
import { NavegacaoComponent } from './navegacao/navegacao.component';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from "./not-found/not-found.component";


@NgModule({
  declarations: [
    AppComponent,
    ListarComponent,
    ApagarComponent,
    IncluirComponent,
    AlterarComponent,
    HeaderComponent,
    NavegacaoComponent,
    HomeComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent},
      { path: 'listar', component: ListarComponent},
      { path: 'incluir', component: IncluirComponent},
      ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
