import { DromaderoPage } from './app.po';

describe('dromadero App', () => {
  let page: DromaderoPage;

  beforeEach(() => {
    page = new DromaderoPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
