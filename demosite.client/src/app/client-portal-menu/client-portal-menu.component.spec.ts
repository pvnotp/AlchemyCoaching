import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientPortalMenuComponent } from './client-portal-menu.component';

describe('ClientPortalMenuComponent', () => {
  let component: ClientPortalMenuComponent;
  let fixture: ComponentFixture<ClientPortalMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ClientPortalMenuComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientPortalMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
