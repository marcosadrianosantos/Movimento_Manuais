import { Component, OnInit } from '@angular/core';
import { MovimentoManualDataService } from '../_data-services/movimentoManual.data-service';

@Component({
  selector: 'app-movimento-manual',
  templateUrl: './movimento-manual.component.html',
  styleUrls: ['./movimento-manual.component.css']
})
export class MovimentoManualComponent implements OnInit {

  movimentosManuais: any[] = [];
  produtos: any[] = [];
  cosifs: any[] = [];
  movimentoManual: any = {};
  disabled: boolean = true;

  constructor(private movimentoManualDataService: MovimentoManualDataService,
              private produtoDataService: MovimentoManualDataService,
              private cosifDataService: MovimentoManualDataService) { }

  ngOnInit() {
    this.get();
    this.getProduto();
  }

  get() {
    this.movimentoManualDataService.get().subscribe((data: any[]) => {
      this.movimentosManuais = data;
    }, error => {
      console.log(error);
      alert('Erro interno do sistema');
    })
  }

  //Fazer lógica para buscar o cosif com relação a descrição selecionada do produto

  getProduto(){
    this.produtoDataService.getProduto().subscribe((data: any[])=> {
      this.produtos = data;
    }, error => {
      console.log(error);
      alert('Erro interno do sistema');
    })
  }

  getCosif(){
    this.cosifDataService.getCosif(this.movimentoManual.coD_PRODUTO).subscribe((data: any[])=> {
      this.cosifs = data;
      console.log(data);
    }, error => {
      console.log(error);
      alert('Erro interno do sistema');
    })
  }

  limparForm(){
    this.movimentoManual = {};
    this.disabled = true;
  }

  post() {
    this.movimentoManualDataService.post(this.movimentoManual).subscribe(data =>{
      if(data) {
        alert('Movimento Manual cadastrado com sucesso');
        this.get();
        this.movimentoManual = {};
        this.disabled = true;
      }else {
        alert('Erro ao cadastrar Movimento Manual');
      }
    }, error =>{
      console.log(error);
      alert('Erro interno do sistema');
    })
  }
}
