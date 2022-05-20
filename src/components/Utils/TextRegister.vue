<template>
  <div class="input-box">
    <i v-bind:class="icon"></i>
    <input :type="text" :placeholder="placeholder" required />
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "TextRegister",
  props: ["icon", "placeholder", "text"],
});
</script>

<style scoped></style>
