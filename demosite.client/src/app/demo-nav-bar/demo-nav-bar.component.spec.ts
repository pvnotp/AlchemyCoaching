import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DemoNavBarComponent } from './demo-nav-bar.component';

describe('NavBarComponent', () => {
  let component: DemoNavBarComponent;
  let fixture: ComponentFixture<DemoNavBarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DemoNavBarComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DemoNavBarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
