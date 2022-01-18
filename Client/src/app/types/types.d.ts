interface IProduct {
  sku: number;
  score?: any;
  productId?: any;
  name: string;
  source?: any;
  startDate?: string;
  new?: boolean;
  active?: boolean;
  salePrice: number;
  plot?: string;
  image: string;
}

interface IProductDisplay {
  sku: number;
  name: string;
  image: string;
  salePrice: number;
}
