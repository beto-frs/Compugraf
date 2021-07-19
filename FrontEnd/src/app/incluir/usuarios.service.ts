import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Request , Response } from "./usuario.model";


@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  private POST_API_SERVER = "http:/localhost:8080/api";

  constructor(private http: HttpClient) { }

  createUser(request: Request):Observable<Response> {
    return this.http.post<Response>(this.POST_API_SERVER,request);
  }
}
