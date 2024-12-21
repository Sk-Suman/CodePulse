import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoryblogComponent } from './categoryblog.component';

describe('CategoryblogComponent', () => {
  let component: CategoryblogComponent;
  let fixture: ComponentFixture<CategoryblogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CategoryblogComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CategoryblogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
