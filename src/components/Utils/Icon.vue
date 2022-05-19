<template>
  <i :class="iconName"></i>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Icon",
  props: ["iconName"],
});
</script>
