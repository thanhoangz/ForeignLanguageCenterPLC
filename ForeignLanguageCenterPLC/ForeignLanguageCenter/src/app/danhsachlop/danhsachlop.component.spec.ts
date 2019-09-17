import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhsachlopComponent } from './danhsachlop.component';

describe('DanhsachlopComponent', () => {
  let component: DanhsachlopComponent;
  let fixture: ComponentFixture<DanhsachlopComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DanhsachlopComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhsachlopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
