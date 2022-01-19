import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()

export class MovimentoManualDataService{

  module: string = '/api/movimento_Manual';
  moduleProduto: string = '/api/produto';
  moduleCosif: string='/api/produto_Cosif/';

  constructor(private http: HttpClient){ }

  get(){
    return this.http.get(this.module)
  }

  post(data){
    return this.http.post(this.module, data);
  }

  getProduto(){
    return this.http.get(this.moduleProduto);
  }

  getCosif(codProduto: string){
    return this.http.get(this.moduleCosif + codProduto);
  }
}
