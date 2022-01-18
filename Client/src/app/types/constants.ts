const baseUrl = 'https://localhost:5001/';
export const productsEP = baseUrl + 'products';
export const productsByNameEP = (name: string) => baseUrl + `products/${name}`;
