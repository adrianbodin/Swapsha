export function validateName(name: string){
  if(name.trim().length <= 0){
    return 'Length cant be empty'
  }
  if(name.length > 50){
    return 'Length cant be more than 50'
  }
  return '';
}