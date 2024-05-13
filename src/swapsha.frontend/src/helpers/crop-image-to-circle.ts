export const cropToSquare = (image: File | null, crop: { x: number, y: number, width: number, height: number }): Promise<File> => {
  return new Promise((resolve) => {
    if (image === null) {
      throw new Error("Image is null");
    }

    const img = new Image();
    img.onload = () => {
      const canvas = document.createElement('canvas');
      const ctx = canvas.getContext('2d')!;
      canvas.width = crop.width;
      canvas.height = crop.height;
      ctx.drawImage(img, crop.x, crop.y, crop.width, crop.height, 0, 0, crop.width, crop.height);
      canvas.toBlob((blob) => {
        resolve(new File([blob as Blob], "newFile.png", { type: 'image/png' }));
      });
    };
    img.src = URL.createObjectURL(image);
  });
};