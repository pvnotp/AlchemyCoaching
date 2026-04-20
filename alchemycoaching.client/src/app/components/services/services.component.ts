import { Component, inject } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Store } from '@ngrx/store';
import { selectUser } from '../../store/selectors/auth.selectors';

@Component({
  selector: 'app-services',
  imports: [RouterLink],
  templateUrl: './services.component.html',
  styleUrl: './services.component.scss'
})
export class ServicesComponent{
  private store = inject(Store);
  user = this.store.selectSignal(selectUser);

}
